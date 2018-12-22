using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashTournamentSummary
    {
        [JsonProperty("bracketId")]
        public long BracketId { get; set; }
        [JsonProperty("rosterId")]
        public string RosterId { get; set; }
        [JsonProperty("state")]
        public LolClashTournamentState State { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
    }
}
