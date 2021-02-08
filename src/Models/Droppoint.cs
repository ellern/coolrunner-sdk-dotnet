using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoolRunner.SDK.Models
{
    public class Droppoint
    {
        [JsonProperty(PropertyName = "droppoint_id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "carrier")]
        public string Carrier { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "distance")]
        public int? Distance { get; set; }

        [JsonProperty(PropertyName = "address")]
        public DroppointAddress Address { get; set; }

        [JsonProperty(PropertyName = "coordinate")]
        public DroppointCoordinate Coordinate { get; set; }

        [JsonProperty(PropertyName = "opening_hours")]
        public Dictionary<string, DroppointOpeningHours> OpeningHours { get; set; }
    }

    public class DroppointAddress
    {
        [JsonProperty(PropertyName = "street")]
        public string Street { get; set; }

        [JsonProperty(PropertyName = "postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "country_code")]
        public string CountryCode { get; set; }
    }

    public class DroppointCoordinate
    {
        [JsonProperty(PropertyName = "latitude")]
        public string Latitude { get; set; }

        [JsonProperty(PropertyName = "longitude")]
        public string Longitude { get; set; }
    }

    public class DroppointOpeningHours
    {
        [JsonProperty(PropertyName = "from")]
        public string From { get; set; }

        [JsonProperty(PropertyName = "to")]
        public string To { get; set; }
    }
}
