using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSuggestedPlayersSuggestedPlayersPlayerStatus
    {
        [JsonProperty("currentLobbyStatus")]
        public LolSuggestedPlayersSuggestedPlayersLobbyStatus CurrentLobbyStatus { get; set; }
        [JsonProperty("lastQueuedLobbyStatus")]
        public LolSuggestedPlayersSuggestedPlayersLobbyStatus LastQueuedLobbyStatus { get; set; }
    }
}
