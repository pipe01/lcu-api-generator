using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PlayerStatSummaries
    {
        [JsonProperty("playerStatSummarySet")]
        public PlayerStatSummary[] PlayerStatSummarySet { get; set; }
    }
}
