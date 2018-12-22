using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolContentTargetingRankedOverviewQueue
    {
        [JsonProperty("positions")]
        public LolContentTargetingRankedPositionInfo[] Positions { get; set; }
        [JsonProperty("queueType")]
        public LolContentTargetingRankedQueue QueueType { get; set; }
    }
}
