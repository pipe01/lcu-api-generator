using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderGameflowGameClient
    {
        [JsonProperty("running")]
        public bool Running { get; set; }
    }
}
