using Newtonsoft.Json;

namespace LCU_API_Generator
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
