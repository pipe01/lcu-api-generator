using Newtonsoft.Json;

namespace LCU_API_Generator
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
