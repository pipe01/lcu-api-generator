//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class MatchmakingLcdsQueueInfo
    {
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("waitTime")]
        public long WaitTime { get; set; }
    }
}
