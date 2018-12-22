using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyGameflowSession
    {
        [JsonProperty("gameClient")]
        public LolLobbyGameflowGameClient GameClient { get; set; }
        [JsonProperty("gameDodge")]
        public LolLobbyGameflowGameDodge GameDodge { get; set; }
        [JsonProperty("phase")]
        public LolLobbyGameflowPhase Phase { get; set; }
    }
}