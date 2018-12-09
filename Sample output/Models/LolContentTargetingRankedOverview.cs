using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolContentTargetingRankedOverview
    {
        [JsonProperty("highestRankedEntry")]
        public LolContentTargetingRankedPositionInfo HighestRankedEntry { get; set; }
        [JsonProperty("queues")]
        public LolContentTargetingRankedOverviewQueue[] Queues { get; set; }
    }
}
