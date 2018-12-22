using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
