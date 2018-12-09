using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashMatchmakingReadyCheckResource
    {
        [JsonProperty("declinerIds")]
        public long[] DeclinerIds { get; set; }
        [JsonProperty("dodgeWarning")]
        public LolClashMatchmakingDodgeWarning DodgeWarning { get; set; }
        [JsonProperty("playerResponse")]
        public LolClashMatchmakingReadyCheckResponse PlayerResponse { get; set; }
        [JsonProperty("state")]
        public LolClashMatchmakingReadyCheckState State { get; set; }
        [JsonProperty("timer")]
        public float Timer { get; set; }
    }
}
