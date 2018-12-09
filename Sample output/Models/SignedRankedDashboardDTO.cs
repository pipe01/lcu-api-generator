using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class SignedRankedDashboardDTO
    {
        [JsonProperty("highestPreviousSeasonRank")]
        public string HighestPreviousSeasonRank { get; set; }
        [JsonProperty("highestPreviousSeasonTier")]
        public string HighestPreviousSeasonTier { get; set; }
        [JsonProperty("jwt")]
        public string Jwt { get; set; }
        [JsonProperty("queues")]
        public RankedDashboardQueueDTO[] Queues { get; set; }
    }
}
