using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyGameflowGameClient
    {
        [JsonProperty("running")]
        public bool Running { get; set; }
    }
}
