using CourvixVPN.API.Exceptions;
using CourvixVPN.API.Models;

namespace CourvixVPN.API.Interfaces;

/// <summary>
///     Represents a base Courvix API wrapper
/// </summary>
public interface ICourvixApi
{
    /// <summary>
    ///     Gets all the VPN servers available
    /// </summary>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <exception cref="ApiException">
    ///     Thrown when the API returns a bad status code
    /// </exception>
    /// <returns>An <see cref="IList{T}" /> of all the servers</returns>
    Task<List<Server>?> GetServersAsync(CancellationToken cancellationToken = default);
}