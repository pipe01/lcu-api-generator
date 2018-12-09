using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashBracketReadyNotification
    {
        [JsonProperty("bracketId")]
        public long BracketId { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
    }
}
