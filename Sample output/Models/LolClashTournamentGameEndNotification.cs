using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashTournamentGameEndNotification
    {
        [JsonProperty("bracketId")]
        public long BracketId { get; set; }
        [JsonProperty("currentMatchId")]
        public long CurrentMatchId { get; set; }
        [JsonProperty("notifyReason")]
        public LolClashRosterNotifyReason NotifyReason { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
    }
}
