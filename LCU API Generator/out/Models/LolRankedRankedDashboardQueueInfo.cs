using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRankedRankedDashboardQueueInfo
    {
        [JsonProperty("challengerNextPromotionUpdateInMs")]
        public long ChallengerNextPromotionUpdateInMs { get; set; }
        [JsonProperty("isPositionRanks")]
        public bool IsPositionRanks { get; set; }
        [JsonProperty("leagueTier")]
        public LolRankedLeagueTier LeagueTier { get; set; }
        [JsonProperty("leagues")]
        public LolRankedLeagueDivisionInfo[] Leagues { get; set; }
        [JsonProperty("maxLeagueSize")]
        public long MaxLeagueSize { get; set; }
        [JsonProperty("positions")]
        public LolRankedRankedPositionInfo[] Positions { get; set; }
        [JsonProperty("previousSeasonDivision")]
        public LolRankedLeagueDivision PreviousSeasonDivision { get; set; }
        [JsonProperty("previousSeasonTier")]
        public LolRankedLeagueTier PreviousSeasonTier { get; set; }
        [JsonProperty("provisionalGameThreshold")]
        public int ProvisionalGameThreshold { get; set; }
        [JsonProperty("queueType")]
        public LolRankedLeagueQueueType QueueType { get; set; }
        [JsonProperty("requesterLeagueDivision")]
        public LolRankedLeagueDivision RequesterLeagueDivision { get; set; }
        [JsonProperty("requesterName")]
        public string RequesterName { get; set; }
    }
}
