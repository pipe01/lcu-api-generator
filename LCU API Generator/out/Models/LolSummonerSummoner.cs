using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSummonerSummoner
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("internalName")]
        public string InternalName { get; set; }
        [JsonProperty("lastSeasonHighestRank")]
        public string LastSeasonHighestRank { get; set; }
        [JsonProperty("percentCompleteForNextLevel")]
        public int PercentCompleteForNextLevel { get; set; }
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }
        [JsonProperty("puuid")]
        public string Puuid { get; set; }
        [JsonProperty("rerollPoints")]
        public LolSummonerSummonerRerollPoints RerollPoints { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
        [JsonProperty("xpSinceLastLevel")]
        public long XpSinceLastLevel { get; set; }
        [JsonProperty("xpUntilNextLevel")]
        public long XpUntilNextLevel { get; set; }
    }
}
