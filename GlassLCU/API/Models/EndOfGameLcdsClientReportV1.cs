using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class EndOfGameLcdsClientReportV1
    {
        [JsonProperty("comments")]
        public string Comments { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("offenderSummonerId")]
        public long OffenderSummonerId { get; set; }
        [JsonProperty("offenses")]
        public string Offenses { get; set; }
    }
}
