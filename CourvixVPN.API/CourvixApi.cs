using CourvixVPN.API.Interfaces;
using CourvixVPN.API.Models;
using CourvixVPN.API.Utils;

namespace CourvixVPN.API;

public class CourvixApi : ICourvixApi
{
    private readonly Requester _requester = new();

    public async Task<List<Server>?> GetServersAsync(CancellationToken cancellationToken = default)
    { 
        return await _requester.Request<List<Server>>(HttpMethod.Get, "/vpn/servers", null);
    }
}