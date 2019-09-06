using System.Net.Http;

namespace CoolRunner.SDK.Clients
{
    public class ShipmentsClient : BaseClient
    {
        private readonly HttpClient _httpClient;

        public ShipmentsClient(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }


    }
}
