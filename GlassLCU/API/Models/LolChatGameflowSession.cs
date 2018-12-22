using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
