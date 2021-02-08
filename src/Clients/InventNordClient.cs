using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoolRunner.SDK.Clients
{
    public class InventNordClient : BaseClient
    {
        private readonly HttpClient _httpClient;

        public InventNordClient(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }

        public Task CreateOrder() => Task.CompletedTask;

        /// <summary>
        /// Update DAO package size and weight
        /// </summary>
        /// <param name="weight">Package weight in grams</param>
        /// <param name="length">Package length in cm</param>
        /// <param name="height">Package height in cm</param>
        /// <param name="width">Package width in cm</param>
        /// <returns></returns>
        public Task<PcnUpdatePackageResponse> UpdatePackage(int weight, int length, int height, int width)
        {
            var data = new Dictionary<string, object>
            {
                { "weight", weight },
                { "length", length },
                { "height", height },
                { "width", width },
            };

            return PostAsync<PcnUpdatePackageResponse>(Endpoints.PCN("update", "weight"), data);
        }

        /// <summary>
        /// Get PDF from order
        /// </summary>
        /// <param name="uniqueId">The full link with the unique_id to this call is returned with the create shipment response!</param>
        /// <returns></returns>
        public Task<byte[]> PDF(string uniqueId)
        {
            /*
            "PDF is returned as body
            Append ?download=1 to the url, to force download
             */

            throw new System.NotImplementedException();
        }
    }

    public class PcnUpdatePackageResponse
    {
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "pcn_pack_id")]
        public string PackId { get; set; }

        [JsonProperty(PropertyName = "shop_label_link")]
        public string ShopLabelLink { get; set; }
    }
}
