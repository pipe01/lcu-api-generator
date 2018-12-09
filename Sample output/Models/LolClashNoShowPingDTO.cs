using Newtonsoft.Json;

namespace LCU_API_Generator
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
