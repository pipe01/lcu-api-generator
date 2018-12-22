using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyGameflowGameDodge
    {
        [JsonProperty("dodgeIds")]
        public long[] DodgeIds { get; set; }
        [JsonProperty("phase")]
        public LolLobbyGameflowPhase Phase { get; set; }
        [JsonProperty("state")]
        public LolLobbyMatchmakingDodgeState State { get; set; }
    }
}
