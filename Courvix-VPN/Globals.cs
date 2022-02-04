using DiscordRPC.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courvix_VPN
{
    public static class Globals
    {
        public static DiscordRPC.DiscordRpcClient RPCClient = new DiscordRPC.DiscordRpcClient("939276152797814834");
        public static readonly DiscordRPC.RichPresence RichPresence = new DiscordRPC.RichPresence
        {
            State = "Not Connected",
            Assets = new DiscordRPC.Assets
            {
                LargeImageKey = "network_plain",
                SmallImageKey = "small"
            }, 
            Buttons = new DiscordRPC.Button[]
            {
                new DiscordRPC.Button
                {
                    Label = "Website",
                    Url = "https://courvix.com"
                }
            }
        };

        public static void SetRPC()
        {
            var settings = SettingsManager.Load();
            if (settings.DiscordRPC)
            {
                RPCClient.SetPresence(RichPresence);
            }
        }
    }
}
