using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMatchmakingMatchmakingReadyCheckResource
    {
        [JsonProperty("declinerIds")]
        public long[] DeclinerIds { get; set; }
        [JsonProperty("dodgeWarning")]
        public LolMatchmakingMatchmakingDodgeWarning DodgeWarning { get; set; }
        [JsonProperty("playerResponse")]
        public LolMatchmakingMatchmakingReadyCheckResponse PlayerResponse { get; set; }
        [JsonProperty("state")]
        public LolMatchmakingMatchmakingReadyCheckState State { get; set; }
        [JsonProperty("suppressUx")]
        public bool SuppressUx { get; set; }
        [JsonProperty("timer")]
        public float Timer { get; set; }
    }
}
