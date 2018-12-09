using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolEndOfGameEndOfGamePlayerComplaintV2
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("offenses")]
        public string Offenses { get; set; }
        [JsonProperty("reportedSummonerId")]
        public long ReportedSummonerId { get; set; }
    }
}
