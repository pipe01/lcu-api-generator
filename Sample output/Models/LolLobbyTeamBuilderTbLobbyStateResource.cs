using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderTbLobbyStateResource
    {
        [JsonProperty("afkCheckState")]
        public LolLobbyTeamBuilderAfkCheckStateV1 AfkCheckState { get; set; }
        [JsonProperty("championSelectState")]
        public LolLobbyTeamBuilderChampionSelectStateV1 ChampionSelectState { get; set; }
        [JsonProperty("counter")]
        public int Counter { get; set; }
        [JsonProperty("matchmakingState")]
        public LolLobbyTeamBuilderTBDMatchmakingState MatchmakingState { get; set; }
        [JsonProperty("phaseName")]
        public string PhaseName { get; set; }
        [JsonProperty("premadeState")]
        public LolLobbyTeamBuilderTbLobbyPremadeStateResource PremadeState { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("useInventoryPath2018")]
        public bool UseInventoryPath2018 { get; set; }
    }
}
