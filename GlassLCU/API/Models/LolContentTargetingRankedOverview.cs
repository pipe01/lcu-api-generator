using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
