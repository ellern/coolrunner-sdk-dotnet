using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoolRunner.SDK.Models
{
    public class FreightRates
    {
        [JsonProperty(PropertyName = "DK")]
        public List<FreightRate> DK { get; set; }

        [JsonProperty(PropertyName = "SE")]
        public List<FreightRate> SE { get; set; }

        [JsonProperty(PropertyName = "DE")]
        public List<FreightRate> DE { get; set; }
    }
}
