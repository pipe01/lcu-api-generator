using Newtonsoft.Json;

namespace LCU_API_Generator
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
