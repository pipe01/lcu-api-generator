using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RosterMatchAggregatedStatsDTO
    {
        [JsonProperty("duration")]
        public long Duration { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("kills")]
        public int Kills { get; set; }
        [JsonProperty("loserBracket")]
        public bool LoserBracket { get; set; }
        [JsonProperty("opponentKills")]
        public int OpponentKills { get; set; }
        [JsonProperty("opponentLogo")]
        public int OpponentLogo { get; set; }
        [JsonProperty("opponentLogoColor")]
        public int OpponentLogoColor { get; set; }
        [JsonProperty("opponentShortName")]
        public string OpponentShortName { get; set; }
        [JsonProperty("playerChampionIds")]
        public object PlayerChampionIds { get; set; }
        [JsonProperty("round")]
        public int Round { get; set; }
        [JsonProperty("win")]
        public bool Win { get; set; }
    }
}