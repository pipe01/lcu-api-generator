using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LeaguesLcdsSummonerLeagueListDTO
    {
        [JsonProperty("entries")]
        public LeaguesLcdsLeagueItemDTO[] Entries { get; set; }
        [JsonProperty("nextApexUpdate")]
        public long NextApexUpdate { get; set; }
        [JsonProperty("requestorsName")]
        public string RequestorsName { get; set; }
        [JsonProperty("requestorsRank")]
        public string RequestorsRank { get; set; }
        [JsonProperty("tier")]
        public string Tier { get; set; }
    }
}
