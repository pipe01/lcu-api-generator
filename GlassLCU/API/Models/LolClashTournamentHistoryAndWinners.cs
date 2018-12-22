using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashTournamentHistoryAndWinners
    {
        [JsonProperty("tournamentHistory")]
        public LolClashTournament[] TournamentHistory { get; set; }
        [JsonProperty("tournamentWinners")]
        public LolClashTournamentWinnerHistory TournamentWinners { get; set; }
    }
}
