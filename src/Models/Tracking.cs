using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoolRunner.SDK.Models
{
    public class Tracking
    {
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "carrier")]
        public string Carrier { get; set; }

        [JsonProperty(PropertyName = "package_number")]
        public string PackageNumber { get; set; }

        [JsonProperty(PropertyName = "tracking")]
        public TrackingInformation Tracking { get; set; }
    }

    public class TrackingInformation
    {
        [JsonProperty(PropertyName = "status")]
        public TrackingStatus Status { get; set; }

        [JsonProperty(PropertyName = "history")]
        public List<TrackingHistory> History { get; set; }
    }

    public class TrackingStatus
    {
        [JsonProperty(PropertyName = "header")]
        public string Header { get; set; }

        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }
    }

    public class TrackingHistory
    {
        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}
