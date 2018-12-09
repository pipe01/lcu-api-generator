using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class GameQueuesLcdsMatchingThrottleConfig
    {
        [JsonProperty("cacheName")]
        public string CacheName { get; set; }
        [JsonProperty("limit")]
        public long Limit { get; set; }
    }
}
