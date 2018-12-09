using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RankedLeagueItemDTO
    {
        [JsonProperty("apexDaysUntilDecay")]
        public int ApexDaysUntilDecay { get; set; }
        [JsonProperty("inactive")]
        public bool Inactive { get; set; }
        [JsonProperty("leagueName")]
        public string LeagueName { get; set; }
        [JsonProperty("leaguePoints")]
        public int LeaguePoints { get; set; }
        [JsonProperty("loses")]
        public int Loses { get; set; }
        [JsonProperty("miniSeries")]
        public RankedLeagueMiniSeriesDTO MiniSeries { get; set; }
        [JsonProperty("playerOrTeamId")]
        public string PlayerOrTeamId { get; set; }
        [JsonProperty("playerOrTeamName")]
        public string PlayerOrTeamName { get; set; }
        [JsonProperty("queueType")]
        public LolRankedStatsRankedQueue QueueType { get; set; }
        [JsonProperty("rank")]
        public RankedDivision Rank { get; set; }
        [JsonProperty("tier")]
        public LolRankedStatsRankedTier Tier { get; set; }
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}