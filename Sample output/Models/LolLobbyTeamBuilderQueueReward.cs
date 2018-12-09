using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderQueueReward
    {
        [JsonProperty("isChampionPointsEnabled")]
        public bool IsChampionPointsEnabled { get; set; }
        [JsonProperty("isIpEnabled")]
        public bool IsIpEnabled { get; set; }
        [JsonProperty("isXpEnabled")]
        public bool IsXpEnabled { get; set; }
        [JsonProperty("partySizeIpRewards")]
        public int[] PartySizeIpRewards { get; set; }
    }
}
