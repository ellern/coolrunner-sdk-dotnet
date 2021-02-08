using Newtonsoft.Json;
using CoolRunner.SDK.Clients;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CoolRunner.SDK
{
    /// <summary>
    /// CoolRunner docs available at:
    /// https://docs.coolrunner.dk/
    /// https://docs.coolrunner.dk/pcn/
    /// </summary>
    public class CoolRunnerClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _url;
        private readonly string _apiToken;
        private readonly string _apiEmail;

        public FreightRatesClient FreightRates { get; set; }
        public ShipmentsClient Shipments { get; set; }
        public InventNordClient InventNord { get; set; }

        /// <summary>
        /// Creates a new instance of the CoolRunnerClient
        /// </summary>
        /// <param name="apiEmail"></param>
        /// <param name="apiToken"></param>
        /// <param name="developerId">The value could be your company name or name of the integration, and maybe even include a version number</param>
        public CoolRunnerClient(string apiEmail, string apiToken, string developerId)
        {
            _url = "https://api.coolrunner.dk/";
            _apiEmail = apiEmail;
            _apiToken = apiToken;
            _httpClient = BuildHttpClient(_url, $"{_apiEmail}:{_apiToken}", developerId, null);

            FreightRates = new FreightRatesClient(_httpClient);
            Shipments = new ShipmentsClient(_httpClient);
            InventNord = new InventNordClient(_httpClient);
        }

        /// <summary>
        /// https://api.coolrunner.dk/v1/me
        /// </summary>
        /// <returns></returns>
        public async Task<string> Me()
        {
            var form = new List<KeyValuePair<string, string>>();
            var request = await _httpClient.PostAsync(Endpoints.Me(), new FormUrlEncodedContent(form)).ConfigureAwait(false);
            var response = await request.Content.ReadAsStringAsync().ConfigureAwait(false);

            return response;
        }

        private HttpClient BuildHttpClient(string baseUrl, string apiKey, string developerId, string accept)
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes(apiKey)));
            httpClient.DefaultRequestHeaders.Add("Accept", accept ?? "application/json");
            httpClient.DefaultRequestHeaders.Add("User-Agent", "CoolRunner SDK .NET Core");

            if (developerId != null)
            {
                httpClient.DefaultRequestHeaders.Add("X-Developer-Id", developerId);
            }

            return httpClient;
        }
    }
}
