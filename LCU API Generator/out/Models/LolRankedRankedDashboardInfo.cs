using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRankedRankedDashboardInfo
    {
        [JsonProperty("highestPreviousSeasonDivision")]
        public LolRankedLeagueDivision HighestPreviousSeasonDivision { get; set; }
        [JsonProperty("highestPreviousSeasonTier")]
        public LolRankedLeagueTier HighestPreviousSeasonTier { get; set; }
        [JsonProperty("highestRankedEntry")]
        public LolRankedRankedPositionInfo HighestRankedEntry { get; set; }
        [JsonProperty("queues")]
        public LolRankedRankedDashboardQueueInfo[] Queues { get; set; }
    }
}
