using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Courvix_VPN
{
    public static class Extensions
    {
        public static async Task<T> GetAsync<T>(this HttpClient _client, string url, CancellationToken cancellationToken = default)
        {
            using (var response = await _client.GetAsync(url))
            {
                return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            }
        }
    }
}