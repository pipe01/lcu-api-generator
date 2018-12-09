using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashTournamentWinnerHistory
    {
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
        [JsonProperty("winners")]
        public LolClashTournamentWinnerInfo[] Winners { get; set; }
    }
}
