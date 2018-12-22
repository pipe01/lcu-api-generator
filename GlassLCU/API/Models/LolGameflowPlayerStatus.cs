using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGameflowPlayerStatus
    {
        [JsonProperty("canInviteOthersAtEog")]
        public bool CanInviteOthersAtEog { get; set; }
        [JsonProperty("currentLobbyStatus")]
        public LolGameflowLobbyStatus CurrentLobbyStatus { get; set; }
        [JsonProperty("lastQueuedLobbyStatus")]
        public LolGameflowLobbyStatus LastQueuedLobbyStatus { get; set; }
    }
}
