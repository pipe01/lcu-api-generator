using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRankedStatsRankedData
    {
        [JsonProperty("rankedData")]
        public LolRankedStatsRankedEntry[] RankedData { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
