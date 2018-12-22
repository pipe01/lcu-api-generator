using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PlayerLifetimeStats
    {
        [JsonProperty("playerStatSummaries")]
        public PlayerStatSummaries PlayerStatSummaries { get; set; }
    }
}
