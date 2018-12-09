using Newtonsoft.Json;

namespace LCU_API_Generator
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
