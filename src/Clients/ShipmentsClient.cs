using CoolRunner.SDK.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoolRunner.SDK.Clients
{
    public class ShipmentsClient : BaseClient
    {
        private readonly HttpClient _httpClient;

        public ShipmentsClient(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<Tracking> Tracking(string packageNumber) => GetAsync<Tracking>(Endpoints.Tracking(packageNumber));
    }
}
