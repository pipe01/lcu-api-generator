using Newtonsoft.Json;

namespace LCU_API_Generator
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
