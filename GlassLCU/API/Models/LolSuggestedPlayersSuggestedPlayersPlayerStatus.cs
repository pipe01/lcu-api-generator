using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
