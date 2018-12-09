using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRegaliaSummoner
    {
        [JsonProperty("lastSeasonHighestRank")]
        public string LastSeasonHighestRank { get; set; }
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }
        [JsonProperty("puuid")]
        public string Puuid { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}
