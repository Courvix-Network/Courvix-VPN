using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Courvix_VPN
{
    public static class Strings
    {
        private static string _openVpnPath;
        public static string OpenVpnPath
        {
            get
            {
                if (_openVpnPath != null)
                    return _openVpnPath;
                using (var softwareKey = Registry.LocalMachine.OpenSubKey("SOFTWARE"))
                {
                    using (var openVpnKey = softwareKey.OpenSubKey("OpenVPN"))
                    {
                        _openVpnPath = openVpnKey?.GetValue("exe_path")?.ToString();
                    }
                }

                return _openVpnPath;
            }
        }

        public static readonly string Data =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Courvix");
        public static readonly string ErrorLogs =
            Path.Combine(Data, "error.log");
        public static readonly string OpenVpnLogs = Path.Combine(Data, "openvpnoutput.txt");
        public static readonly string ConfigDirectory = Path.Combine(Data, "configs");
    }
}
