using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyPlayerStatus
    {
        [JsonProperty("canInviteOthersAtEog")]
        public bool CanInviteOthersAtEog { get; set; }
        [JsonProperty("currentLobbyStatus")]
        public LolLobbyLobbyStatus CurrentLobbyStatus { get; set; }
        [JsonProperty("lastQueuedLobbyStatus")]
        public LolLobbyLobbyStatus LastQueuedLobbyStatus { get; set; }
    }
}
