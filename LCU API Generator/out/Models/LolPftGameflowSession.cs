using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPftGameflowSession
    {
        [JsonProperty("gameDodge")]
        public LolPftGameflowGameDodge GameDodge { get; set; }
        [JsonProperty("phase")]
        public LolPftGameflowPhase Phase { get; set; }
    }
}
