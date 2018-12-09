using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRankedStatsRankedEntry
    {
        [JsonProperty("apexDaysUntilDecay")]
        public long ApexDaysUntilDecay { get; set; }
        [JsonProperty("division")]
        public long Division { get; set; }
        [JsonProperty("games")]
        public long Games { get; set; }
        [JsonProperty("isApexTier")]
        public bool IsApexTier { get; set; }
        [JsonProperty("leagueName")]
        public string LeagueName { get; set; }
        [JsonProperty("lp")]
        public long Lp { get; set; }
        [JsonProperty("rankedQueue")]
        public LolRankedStatsRankedQueue RankedQueue { get; set; }
        [JsonProperty("rankedTier")]
        public LolRankedStatsRankedTier RankedTier { get; set; }
        [JsonProperty("wins")]
        public long Wins { get; set; }
    }
}
