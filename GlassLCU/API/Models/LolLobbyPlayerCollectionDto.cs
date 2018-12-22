using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyPlayerCollectionDto
    {
        [JsonProperty("players")]
        public LolLobbyPlayerDto[] Players { get; set; }
    }
}
