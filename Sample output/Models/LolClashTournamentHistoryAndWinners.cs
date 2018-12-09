using Newtonsoft.Json;

namespace LCU_API_Generator
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
