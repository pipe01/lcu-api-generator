using Newtonsoft.Json;

namespace LCU_API_Generator
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
