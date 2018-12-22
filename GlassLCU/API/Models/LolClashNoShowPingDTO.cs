using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashNoShowPingDTO
    {
        [JsonProperty("dodgeTime")]
        public long DodgeTime { get; set; }
        [JsonProperty("matchId")]
        public long MatchId { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
    }
}