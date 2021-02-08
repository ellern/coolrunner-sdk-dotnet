using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CoolRunner.SDK.Models
{
    public class Shipment
    {
        [JsonProperty(PropertyName = "order_id")]
        public int OrderId { get; set; }

        [JsonProperty(PropertyName = "grand_total_excl_tax")]
        public int GrandTotalExclTax { get; set; }

        [JsonProperty(PropertyName = "grand_total_incl_tax")]
        public int GrandTotalInclTax { get; set; }

        [JsonProperty(PropertyName = "reference")]
        public string Reference { get; set; }

        [JsonProperty(PropertyName = "shipment_id")]
        public int ShipmentId { get; set; }

        [JsonProperty(PropertyName = "price_excl_tax")]
        public int PriceExclTax { get; set; }

        [JsonProperty(PropertyName = "price_incl_tax")]
        public int PriceInclTax { get; set; }

        [JsonProperty(PropertyName = "package_number")]
        public long PackageNumber { get; set; }

        [JsonProperty(PropertyName = "labelless_code")]
        public string LabellessCode { get; set; }

        [JsonProperty(PropertyName = "pdf_base64")]
        public string PDFBase64 { get; set; }

        [JsonProperty(PropertyName = "pdf_link")]
        public string PDFLink { get; set; }
    }


}
