using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashTournamentGameEnd
    {
        [JsonProperty("bracketId")]
        public long BracketId { get; set; }
        [JsonProperty("oldBracket")]
        public LolClashBracket OldBracket { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
        [JsonProperty("tournamentNameLocKey")]
        public string TournamentNameLocKey { get; set; }
        [JsonProperty("tournamentNameLocKeySecondary")]
        public string TournamentNameLocKeySecondary { get; set; }
    }
}