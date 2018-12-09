using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PlayerStatSummary
    {
        [JsonProperty("leaves")]
        public long Leaves { get; set; }
        [JsonProperty("losses")]
        public long Losses { get; set; }
        [JsonProperty("maxRating")]
        public long MaxRating { get; set; }
        [JsonProperty("playerStatSummaryType")]
        public string PlayerStatSummaryType { get; set; }
        [JsonProperty("rating")]
        public long Rating { get; set; }
        [JsonProperty("wins")]
        public long Wins { get; set; }
    }
}
