using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RosterPeriodAggregatedStatsDTO
    {
        [JsonProperty("bracketSize")]
        public int BracketSize { get; set; }
        [JsonProperty("matchStats")]
        public RosterMatchAggregatedStatsDTO[] MatchStats { get; set; }
        [JsonProperty("period")]
        public int Period { get; set; }
        [JsonProperty("playerBids")]
        public object PlayerBids { get; set; }
        [JsonProperty("time")]
        public long Time { get; set; }
    }
}
