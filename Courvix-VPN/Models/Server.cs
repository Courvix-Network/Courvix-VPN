using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courvix_VPN.Models
{
    public class Server
    {

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
