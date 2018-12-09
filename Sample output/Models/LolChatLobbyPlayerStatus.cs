using Newtonsoft.Json;

namespace LCU_API_Generator
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
