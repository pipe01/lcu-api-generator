using Newtonsoft.Json;

namespace LCU_API_Generator
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
