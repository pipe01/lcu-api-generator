using Newtonsoft.Json;

namespace LCU_API_Generator
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
