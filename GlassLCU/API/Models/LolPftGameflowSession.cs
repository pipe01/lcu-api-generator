using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
