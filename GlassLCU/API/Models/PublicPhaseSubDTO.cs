using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PublicPhaseSubDTO
    {
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
        [JsonProperty("replacedPlayerId")]
        public long ReplacedPlayerId { get; set; }
    }
}
