using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolSuggestedPlayersSuggestedPlayersReportedPlayer
    {
        [JsonProperty("reportedSummonerId")]
        public long ReportedSummonerId { get; set; }
    }
}
