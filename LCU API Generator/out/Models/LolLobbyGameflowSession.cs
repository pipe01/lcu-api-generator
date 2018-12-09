using Newtonsoft.Json;

namespace LCU_API_Generator
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
