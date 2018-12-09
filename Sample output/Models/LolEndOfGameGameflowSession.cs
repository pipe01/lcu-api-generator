using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolEndOfGameGameflowSession
    {
        [JsonProperty("gameClient")]
        public LolEndOfGameGameflowClient GameClient { get; set; }
        [JsonProperty("gameData")]
        public LolEndOfGameGameflowGameData GameData { get; set; }
        [JsonProperty("phase")]
        public LolEndOfGameGameflowPhase Phase { get; set; }
    }
}
