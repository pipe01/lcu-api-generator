using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRankedRankedOverviewInfo
    {
        [JsonProperty("highestPreviousSeasonDivision")]
        public LolRankedLeagueDivision HighestPreviousSeasonDivision { get; set; }
        [JsonProperty("highestPreviousSeasonTier")]
        public LolRankedLeagueTier HighestPreviousSeasonTier { get; set; }
        [JsonProperty("highestRankedEntry")]
        public LolRankedRankedPositionInfo HighestRankedEntry { get; set; }
        [JsonProperty("queues")]
        public LolRankedRankedOverviewQueueInfo[] Queues { get; set; }
    }
}
