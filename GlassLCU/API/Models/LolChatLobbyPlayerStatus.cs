using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChatLobbyPlayerStatus
    {
        [JsonProperty("currentLobbyStatus")]
        public LolChatLobbyStatus CurrentLobbyStatus { get; set; }
        [JsonProperty("lastQueuedLobbyStatus")]
        public LolChatLobbyStatus LastQueuedLobbyStatus { get; set; }
    }
}
