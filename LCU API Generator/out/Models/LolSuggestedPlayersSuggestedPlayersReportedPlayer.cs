using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSuggestedPlayersSuggestedPlayersReportedPlayer
    {
        [JsonProperty("reportedSummonerId")]
        public long ReportedSummonerId { get; set; }
    }
}
