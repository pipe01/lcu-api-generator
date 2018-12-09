using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashBracket
    {
        [JsonProperty("currentLoserRound")]
        public int CurrentLoserRound { get; set; }
        [JsonProperty("currentRound")]
        public int CurrentRound { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("isComplete")]
        public bool IsComplete { get; set; }
        [JsonProperty("loserBracketMatches")]
        public BracketMatch[] LoserBracketMatches { get; set; }
        [JsonProperty("matches")]
        public BracketMatch[] Matches { get; set; }
        [JsonProperty("period")]
        public int Period { get; set; }
        [JsonProperty("rosters")]
        public BracketRoster[] Rosters { get; set; }
        [JsonProperty("size")]
        public int Size { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
        [JsonProperty("version")]
        public int Version { get; set; }
    }
}
