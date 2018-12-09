using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashGameflowGameDodge
    {
        [JsonProperty("dodgeIds")]
        public long[] DodgeIds { get; set; }
        [JsonProperty("state")]
        public LolClashMatchmakingDodgeState State { get; set; }
    }
}
