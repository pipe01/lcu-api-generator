using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PlayerInfoDTO
    {
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
        [JsonProperty("position")]
        public string Position { get; set; }
        [JsonProperty("role")]
        public Role Role { get; set; }
        [JsonProperty("teamId")]
        public string TeamId { get; set; }
    }
}
