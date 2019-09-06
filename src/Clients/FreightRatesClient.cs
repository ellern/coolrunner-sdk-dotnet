using CoolRunner.SDK.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoolRunner.SDK.Clients
{
    public class FreightRatesClient : BaseClient
    {
        private readonly HttpClient _httpClient;

        public FreightRatesClient(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<FreightRates> Get(string countryCode) => GetAsync<FreightRates>(Endpoints.FreightRates(countryCode));
    }
}
