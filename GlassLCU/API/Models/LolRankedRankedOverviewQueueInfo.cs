using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRankedRankedOverviewQueueInfo
    {
        [JsonProperty("isPositionRanks")]
        public bool IsPositionRanks { get; set; }
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
    }
}
