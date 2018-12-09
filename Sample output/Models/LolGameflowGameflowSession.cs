using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolGameflowGameflowSession
    {
        [JsonProperty("gameClient")]
        public LolGameflowGameflowGameClient GameClient { get; set; }
        [JsonProperty("gameData")]
        public LolGameflowGameflowGameData GameData { get; set; }
        [JsonProperty("gameDodge")]
        public LolGameflowGameflowGameDodge GameDodge { get; set; }
        [JsonProperty("map")]
        public LolGameflowGameflowGameMap Map { get; set; }
        [JsonProperty("phase")]
        public LolGameflowGameflowPhase Phase { get; set; }
    }
}
