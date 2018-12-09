using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderGameflowSession
    {
        [JsonProperty("gameClient")]
        public LolLobbyTeamBuilderGameflowGameClient GameClient { get; set; }
    }
}
