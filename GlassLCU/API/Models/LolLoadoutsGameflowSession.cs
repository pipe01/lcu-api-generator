using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLoadoutsGameflowSession
    {
        [JsonProperty("gameData")]
        public LolLoadoutsGameflowGameData GameData { get; set; }
        [JsonProperty("phase")]
        public LolLoadoutsGameflowPhase Phase { get; set; }
    }
}
