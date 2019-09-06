using Newtonsoft.Json;

namespace CoolRunner.SDK.Models
{
    public class FreightRate
    {
        [JsonProperty(PropertyName = "carrier")]
        public string Carrier { get; set; }

        [JsonProperty(PropertyName = "carrier_product")]
        public string CarrierProduct { get; set; }

        [JsonProperty(PropertyName = "carrier_service")]
        public string CarrierService { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "weight_from")]
        public int WeightFrom { get; set; }

        [JsonProperty(PropertyName = "weight_to")]
        public int WeightTo { get; set; }

        [JsonProperty(PropertyName = "price_excl_tax")]
        public int PriceExclTax { get; set; }

        [JsonProperty(PropertyName = "price_incl_tax")]
        public int PriceInclTax { get; set; }
    }
}
