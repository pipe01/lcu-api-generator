using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRankedGameflowSession
    {
        [JsonProperty("gameData")]
        public LolRankedGameflowGameData GameData { get; set; }
        [JsonProperty("phase")]
        public LolRankedGameflowPhase Phase { get; set; }
    }
}
