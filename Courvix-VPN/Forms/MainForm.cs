using Courvix_VPN.Forms;
/*
 * Toshiro Tanazaki
 * 
 * Its not the best source but its decent.
 * While i could do a better job I don't feel like it is necessary
 * A simple source just seems to be better for this project\
 * 
 */

using Courvix_VPN.Models;
using OpenVpn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Courvix_VPN.Properties;

namespace Courvix_VPN
{
    public partial class MainForm : Form
    {
        private static readonly HttpClient _client = new HttpClient();
        private static List<Server> _servers;
        private static OpenVPN _openvpn;
        private static string _connectedServer;

        public MainForm()
        {
            InitializeComponent();

        }

        private async void ConnectBTN_Click(object sender, EventArgs e)
        {
            if (ConnectBTN.Text == Resources.Vpn_Disconnect)
            {
                await Task.Run(() => _openvpn.Dispose());
                _openvpn = null;
            }
            else
            {
                var server = _servers.First(x => x.ServerName == serversCB.Text);
                _connectedServer = server.ServerName;
                ConnectBTN.Enabled = false;
                ConnectBTN.Text = Resources.Vpn_Connecting;
                ConnectBTN.ShadowDecoration.Color = Color.Gray;

                await GetConfig(server);
                statuslbl.Text = Resources.Status_Vpn_Connecting;
                connectingIndicator.Visible = true;
                connectingIndicator.Start();
                _openvpn = new OpenVPN(Path.Combine(Strings.ConfigDirectory, server.ServerName), Strings.OpenVpnPath,
                    logPath: Strings.OpenVpnLogs);
                _openvpn.Closed += Manager_Closed;
                _openvpn.Connected += Manager_Connected;
                _openvpn.ConnectionErrored += Manager_ConnectionErrored;
                _openvpn.Output += Manager_Output;
            }
        }

        private void Manager_Output(object sender, string output)
        {
            File.AppendAllText(Strings.OpenVpnLogs, output);
        }

        private async Task GetConfig(Server server)
        {
            if (!Directory.Exists(Strings.ConfigDirectory))
                Directory.CreateDirectory(Strings.ConfigDirectory);
            if (!File.Exists(Path.Combine(Strings.ConfigDirectory, server.ServerName)))
            {
                statuslbl.Text = Resources.Downloading_Config;
                var resp = await _client.GetAsync(server.ConfigLink);
                if ((int) resp.StatusCode == 429)
                {
                    MessageBox.Show(Resources.Failed_Download_Config);
                    Application.Exit();
                }

                File.WriteAllText(Path.Combine(Strings.ConfigDirectory, server.ServerName),
                    await resp.Content.ReadAsStringAsync());
            }
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            
            try
            {
                statuslbl.Text = Resources.Checking_For_Updates;
                await CheckVersion();
                statuslbl.Text = Resources.Checking_For_OpenVPN;
                CheckOpenVPN();
                statuslbl.Text = Resources.Getting_Servers;
                _servers = await _client.GetAsync<List<Server>>("https://courvix.com/vpn/server_list.json");
                _servers = _servers.OrderBy(x => x.CountryCode).ThenBy(x => x.ServerName).ToList();
                serversCB.DataSource = _servers.Where(x => x.Enabled && !x.Down).Select(x => x.ServerName).ToArray();
            }
            catch
            {
                MessageBox.Show(Resources.Server_Load_Failed);
                Application.Exit();
            }

            var settings = SettingsManager.Load();
            RPCCheckbox.Checked = settings.DiscordRPC;
            statuslbl.Text = Resources.Not_Connected;
            lblVersion.Text = "v1.0.3";
        }

        private async Task CheckVersion()
        {
            var clientversion = await _client.GetAsync<ClientVersion>("https://api.courvix.com/vpn/servers");
            if (clientversion.Version > Assembly.GetExecutingAssembly().GetName().Version)
            {
                if (MessageBox.Show(Resources.New_Version_Found, "Courvix VPN",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    statuslbl.Text = Resources.Downloading_Update;
                    var bytes = await _client.GetByteArrayAsync(clientversion.DownloadLink);
                    var fileName = Environment.GetCommandLineArgs().First();
                    if (File.Exists(Path.Combine(Path.GetTempPath(), Path.GetFileName(fileName))))
                    {
                        File.Delete(Path.Combine(Path.GetTempPath(), Path.GetFileName(fileName)));
                    }
                    File.Move(fileName, Path.Combine(Path.GetTempPath(), Path.GetFileName(fileName)));
                    File.WriteAllBytes(fileName, bytes);
                    Process.Start(fileName);
                    Environment.Exit(0);
                }
            }
        }

    private void RPCCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            var settings = SettingsManager.Load();
            settings.DiscordRPC = RPCCheckbox.Checked;
            settings.Save();
            if (settings.DiscordRPC)
            {
                if (Globals.RPCClient.IsInitialized)
                {
                    Globals.RPCClient.SetPresence(Globals.RichPresence);
                }
                else
                {
                    Globals.RPCClient.Initialize();
                    Globals.RPCClient.SetPresence(Globals.RichPresence);
                }
            }
            else
            {
                if (Globals.RPCClient.IsInitialized)
                {
                    Globals.RPCClient.ClearPresence();
                }
                else
                {
                    Globals.RPCClient.Initialize();
                    Globals.RPCClient.ClearPresence();
                }
            }
        }
        private void Manager_ConnectionErrored(object sender, string output)
        {
            _openvpn.Dispose();
            _openvpn = null;
            base.Invoke((MethodInvoker)delegate
            {
                ConnectBTN.Enabled = true;
                ConnectBTN.Text = Resources.Vpn_Connect;
                statuslbl.Text = Resources.Not_Connected;
                CustomMessageBox.Show("Courvix VPN", output);
            });

            Globals.RichPresence.State = $"Disconnected";
            Globals.SetRPC();
        }

        private void Manager_Closed(object sender)
        {
            Globals.RichPresence.State = $"Not Connected";
            Globals.SetRPC();
            base.Invoke((MethodInvoker)delegate
            {
                ConnectBTN.Text = Resources.Vpn_Connect;
                statuslbl.Text = Resources.Not_Connected;
                ConnectBTN.Enabled = true;
            });
        }

        private void Manager_Connected(object sender)
        {
            Globals.RichPresence.State = $"Connected to {_connectedServer}";
            Globals.SetRPC();
            base.Invoke((MethodInvoker)delegate
            {
                ConnectBTN.Text = Resources.Vpn_Disconnect;
                ConnectBTN.Enabled = true;
                statuslbl.Text = "Status: Connected";
                connectingIndicator.Visible = false;
                connectingIndicator.Stop();
            });
        }

        private void CheckOpenVPN()
        {
            if (!File.Exists(Strings.OpenVpnPath))
            {
                CustomMessageBox.Show("Courvix VPN", Resources.OpenVpn_Not_Found);
                CustomMessageBox.Show("Courvix VPN",
                    Resources.OpenVpn_Download_Open);
                Process.Start("https://swupdate.openvpn.org/community/releases/OpenVPN-2.5.5-I602-amd64.msi");
                Environment.Exit(1);
            }
        }

        private void xbtn_Click(object sender, EventArgs e)
        {
            // Make sure RPC is properly cleared on exit
            Globals.RPCClient.Dispose();
            Application.Exit();
        }
    }
}
