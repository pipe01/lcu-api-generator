using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMatchmakingGameflowSession
    {
        [JsonProperty("gameData")]
        public LolMatchmakingGameflowGameData GameData { get; set; }
        [JsonProperty("gameDodge")]
        public LolMatchmakingGameflowGameDodge GameDodge { get; set; }
        [JsonProperty("phase")]
        public LolMatchmakingGameflowPhase Phase { get; set; }
    }
}
