using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
