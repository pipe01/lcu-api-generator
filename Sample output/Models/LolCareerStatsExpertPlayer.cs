using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCareerStatsExpertPlayer
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("expertRank")]
        public int ExpertRank { get; set; }
        [JsonProperty("numOfGames")]
        public int NumOfGames { get; set; }
        [JsonProperty("position")]
        public LolCareerStatsSummonersRiftPosition Position { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
        [JsonProperty("winRate")]
        public float WinRate { get; set; }
    }
}
