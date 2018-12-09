using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RankedLeagueListDTO
    {
        [JsonProperty("entries")]
        public RankedLeagueItemDTO[] Entries { get; set; }
        [JsonProperty("maxLeagueSize")]
        public int MaxLeagueSize { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("nextApexUpdate")]
        public long NextApexUpdate { get; set; }
        [JsonProperty("queue")]
        public string Queue { get; set; }
        [JsonProperty("requestorsName")]
        public string RequestorsName { get; set; }
        [JsonProperty("requestorsRank")]
        public string RequestorsRank { get; set; }
        [JsonProperty("tier")]
        public string Tier { get; set; }
    }
}
