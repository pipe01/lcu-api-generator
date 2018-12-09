using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LeaguesLcdsLeagueListDTO
    {
        [JsonProperty("apexUnlockTimeMillis")]
        public long ApexUnlockTimeMillis { get; set; }
        [JsonProperty("entries")]
        public LeaguesLcdsLeagueItemDTO[] Entries { get; set; }
        [JsonProperty("maxLeagueSize")]
        public long MaxLeagueSize { get; set; }
        [JsonProperty("nextApexUpdate")]
        public long NextApexUpdate { get; set; }
        [JsonProperty("requestorsName")]
        public string RequestorsName { get; set; }
        [JsonProperty("tier")]
        public string Tier { get; set; }
    }
}