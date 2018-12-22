using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RankedOverviewQueueDTO
    {
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
