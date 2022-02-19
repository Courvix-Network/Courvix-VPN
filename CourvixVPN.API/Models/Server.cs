using System.Text.Json.Serialization;

namespace CourvixVPN.API.Models;

/// <summary>
///     Represents a VPN server from the Courvix API
/// </summary>
public class Server
{
    /// <summary>
    ///     The larger country flag corresponding to the servers location
    /// </summary>
    [JsonPropertyName("flagurl")]
    public Uri FlagUrl { get; init; }

    /// <summary>
    ///     The smaller country flag corresponding to the servers location
    /// </summary>
    [JsonPropertyName("flagurl_small")]
    public Uri FlagUrlSmall { get; init; }

    /// <summary>
    ///     The company or organisation that is providing the server
    /// </summary>
    [JsonPropertyName("provider")]
    public string Provider { get; init; }

    /// <summary>
    ///     The DDoS protection provider for the server
    /// </summary>
    [JsonPropertyName("protection")]
    public string Protection { get; init; }

    /// <summary>
    ///     The code of the country that the server is located at
    /// </summary>
    [JsonPropertyName("countrycode")]
    public string CountryCode { get; init; }

    /// <summary>
    ///     Whether the server is enabled
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool IsEnabled { get; init; }

    /// <summary>
    ///     Whether the server is down
    /// </summary>
    [JsonPropertyName("down")]
    public bool IsDown { get; init; }

    /// <summary>
    ///     The URL to fetch the corresponding OpenVPN configuration file
    /// </summary>
    [JsonPropertyName("url")]
    public Uri ConfigurationUrl { get; init; }

    /// <summary>
    ///     The display name of the server
    /// </summary>
    [JsonPropertyName("servername")]
    public string Name { get; init; }
}