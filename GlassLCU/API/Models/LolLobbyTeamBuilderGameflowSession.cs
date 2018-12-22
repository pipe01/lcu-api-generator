using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderGameflowSession
    {
        [JsonProperty("gameClient")]
        public LolLobbyTeamBuilderGameflowGameClient GameClient { get; set; }
    }
}
