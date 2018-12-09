using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashRosterPlayerAggregatedStats
    {
        [JsonProperty("rawStatsMax")]
        public object RawStatsMax { get; set; }
        [JsonProperty("rawStatsSum")]
        public object RawStatsSum { get; set; }
        [JsonProperty("sub")]
        public bool Sub { get; set; }
    }
}
