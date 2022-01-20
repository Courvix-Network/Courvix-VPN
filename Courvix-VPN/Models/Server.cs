using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courvix_VPN.Models
{
    public struct Server
    {
        /*
        
    "flagurl": "https://www.countryflags.com/wp-content/uploads/united-states-of-america-flag-png-large",
    "flagurl_small": "https://www.countryflags.io/us/flat/64.png",
    "provider": "NFOServers.com",
    "protection": "NFOServers.com",
    "countrycode": "US",
    "enabled": true,
    "down": false,
    "url": "https://courvix.com/vpn/configs/NewYorkNFO.ovpn",
    "servername": "New York 1"*/
        [JsonProperty("flagurl")] public string FlagUrl { get; set; }
        [JsonProperty("flagurl_small")] public string FlagUrlSmall { get; set; }
        [JsonProperty("provider")] public string Provider { get; set; }
        [JsonProperty("protection")] public string Protection { get; set; }
        [JsonProperty("countrycode")] public string CountryCode { get; set; }
        [JsonProperty("enabled")] public bool Enabled { get; set; }
        [JsonProperty("down")] public bool Down { get; set; }
        [JsonProperty("url")] public string ConfigLink { get; set; }
        [JsonProperty("servername")] public string ServerName { get; set; }
       
    }
}
