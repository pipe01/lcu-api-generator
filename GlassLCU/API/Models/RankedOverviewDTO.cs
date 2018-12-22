using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RankedOverviewDTO
    {
        [JsonProperty("highestPreviousSeasonRank")]
        public string HighestPreviousSeasonRank { get; set; }
        [JsonProperty("highestPreviousSeasonTier")]
        public string HighestPreviousSeasonTier { get; set; }
        [JsonProperty("queues")]
        public RankedOverviewQueueDTO[] Queues { get; set; }
    }
}
