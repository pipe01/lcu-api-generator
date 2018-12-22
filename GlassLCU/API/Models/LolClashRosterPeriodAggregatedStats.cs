using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashRosterPeriodAggregatedStats
    {
        [JsonProperty("bracketSize")]
        public int BracketSize { get; set; }
        [JsonProperty("matchStats")]
        public LolClashRosterMatchAggregatedStats[] MatchStats { get; set; }
        [JsonProperty("period")]
        public int Period { get; set; }
        [JsonProperty("playerBids")]
        public object PlayerBids { get; set; }
        [JsonProperty("time")]
        public long Time { get; set; }
    }
}
