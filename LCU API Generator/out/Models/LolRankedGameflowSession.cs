using Newtonsoft.Json;

namespace LCU_API_Generator
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
