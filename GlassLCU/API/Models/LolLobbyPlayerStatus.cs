using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
