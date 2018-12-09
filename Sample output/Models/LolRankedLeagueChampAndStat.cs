using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRankedLeagueChampAndStat
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("totalGamePlayed")]
        public long TotalGamePlayed { get; set; }
        [JsonProperty("winRate")]
        public float WinRate { get; set; }
    }
}
