using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathHowToWinCreepScoreDto
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("goldEarned")]
        public long GoldEarned { get; set; }
        [JsonProperty("jungleKills")]
        public int JungleKills { get; set; }
        [JsonProperty("laneKills")]
        public int LaneKills { get; set; }
        [JsonProperty("newRecord")]
        public bool NewRecord { get; set; }
        [JsonProperty("totalKills")]
        public int TotalKills { get; set; }
    }
}
