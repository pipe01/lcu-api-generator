using Newtonsoft.Json;

namespace LCU_API_Generator
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
