using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPerksGameflowSession
    {
        [JsonProperty("gameData")]
        public LolPerksGameflowGameData GameData { get; set; }
        [JsonProperty("phase")]
        public LolPerksGameflowPhase Phase { get; set; }
    }
}
