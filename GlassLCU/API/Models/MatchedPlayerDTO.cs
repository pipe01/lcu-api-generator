using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class MatchedPlayerDTO
    {
        [JsonProperty("captain")]
        public PlayerInfoDTO Captain { get; set; }
        [JsonProperty("players")]
        public PlayerInfoDTO[] Players { get; set; }
        [JsonProperty("rosterId")]
        public string RosterId { get; set; }
    }
}
