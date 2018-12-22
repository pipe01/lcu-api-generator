using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
