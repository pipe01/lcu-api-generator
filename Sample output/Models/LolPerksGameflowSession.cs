using Newtonsoft.Json;

namespace LCU_API_Generator
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
