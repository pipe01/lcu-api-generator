using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLeaverBusterMatchmakingSearchResource
    {
        [JsonProperty("errors")]
        public LolLeaverBusterMatchmakingSearchErrorResource[] Errors { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
    }
}
