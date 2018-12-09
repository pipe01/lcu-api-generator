using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPftGameflowGameDodge
    {
        [JsonProperty("dodgeIds")]
        public long[] DodgeIds { get; set; }
        [JsonProperty("state")]
        public LolPftGameflowGameDodgeState State { get; set; }
    }
}
