using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatGameflowSession
    {
        [JsonProperty("gameData")]
        public LolChatGameflowGameData GameData { get; set; }
        [JsonProperty("map")]
        public LolChatGameflowGameMap Map { get; set; }
        [JsonProperty("phase")]
        public LolChatGameflowPhase Phase { get; set; }
    }
}
