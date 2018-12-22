using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LeaguesLcdsChampionStatInfo
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("stats")]
        public LeaguesLcdsAggregatedStat[] Stats { get; set; }
        [JsonProperty("totalGamesPlayed")]
        public int TotalGamesPlayed { get; set; }
    }
}