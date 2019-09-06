using Newtonsoft.Json;

namespace CoolRunner.SDK.Models
{
    public class ApiResult<T>
    {
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "result")]
        public T Result { get; set; }
    }
}
