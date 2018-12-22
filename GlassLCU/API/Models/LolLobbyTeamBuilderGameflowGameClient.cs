using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderGameflowGameClient
    {
        [JsonProperty("running")]
        public bool Running { get; set; }
    }
}
