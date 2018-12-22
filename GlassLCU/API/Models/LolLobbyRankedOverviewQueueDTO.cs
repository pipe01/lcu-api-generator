using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyRankedOverviewQueueDTO
    {
        [JsonProperty("positionInfos")]
        public LolLobbyRankedPositionInfoDTO[] PositionInfos { get; set; }
        [JsonProperty("positionRanks")]
        public bool PositionRanks { get; set; }
        [JsonProperty("queue")]
        public string Queue { get; set; }
    }
}
