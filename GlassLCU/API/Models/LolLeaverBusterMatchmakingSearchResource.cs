using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
