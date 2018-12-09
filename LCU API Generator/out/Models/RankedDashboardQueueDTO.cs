using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RankedDashboardQueueDTO
    {
        [JsonProperty("leagues")]
        public LeaguesLcdsLeagueListDTO[] Leagues { get; set; }
        [JsonProperty("positionInfos")]
        public RankedPositionInfoDTO[] PositionInfos { get; set; }
        [JsonProperty("positionRanks")]
        public bool PositionRanks { get; set; }
        [JsonProperty("previousSeasonRank")]
        public string PreviousSeasonRank { get; set; }
        [JsonProperty("previousSeasonTier")]
        public string PreviousSeasonTier { get; set; }
        [JsonProperty("provisionalGameThreshold")]
        public int ProvisionalGameThreshold { get; set; }
        [JsonProperty("queue")]
        public string Queue { get; set; }
    }
}
