using Newtonsoft.Json;

namespace LCU_API_Generator
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
