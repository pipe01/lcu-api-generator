using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderMatchmakingReadyCheckResource
    {
        [JsonProperty("declinerIds")]
        public long[] DeclinerIds { get; set; }
        [JsonProperty("dodgeWarning")]
        public LolLobbyTeamBuilderMatchmakingDodgeWarning DodgeWarning { get; set; }
        [JsonProperty("playerResponse")]
        public LolLobbyTeamBuilderMatchmakingReadyCheckResponse PlayerResponse { get; set; }
        [JsonProperty("state")]
        public LolLobbyTeamBuilderMatchmakingReadyCheckState State { get; set; }
        [JsonProperty("timer")]
        public float Timer { get; set; }
    }
}
