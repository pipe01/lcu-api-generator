//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
