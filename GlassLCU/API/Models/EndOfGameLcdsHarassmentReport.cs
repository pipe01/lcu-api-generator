using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class EndOfGameLcdsHarassmentReport
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("offense")]
        public string Offense { get; set; }
        [JsonProperty("reportSource")]
        public string ReportSource { get; set; }
        [JsonProperty("reportedSummonerId")]
        public long ReportedSummonerId { get; set; }
        [JsonProperty("reportingSummonerId")]
        public long ReportingSummonerId { get; set; }
    }
}
