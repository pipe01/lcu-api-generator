using Newtonsoft.Json;

namespace LCU_API_Generator
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
