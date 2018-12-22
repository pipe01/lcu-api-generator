using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyReadyDto
    {
        [JsonProperty("ready")]
        public bool Ready { get; set; }
    }
}
