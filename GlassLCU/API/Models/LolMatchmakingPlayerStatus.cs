using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMatchmakingPlayerStatus
    {
        [JsonProperty("currentLobbyStatus")]
        public LolMatchmakingLobbyStatus CurrentLobbyStatus { get; set; }
        [JsonProperty("lastQueuedLobbyStatus")]
        public LolMatchmakingLobbyStatus LastQueuedLobbyStatus { get; set; }
    }
}
