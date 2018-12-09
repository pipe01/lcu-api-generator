using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PlayerStatSummaries
    {
        [JsonProperty("playerStatSummarySet")]
        public PlayerStatSummary[] PlayerStatSummarySet { get; set; }
    }
}
