using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMatchHistoryRecentlyPlayedSummoner
    {
        [JsonProperty("championId")]
        public long ChampionId { get; set; }
        [JsonProperty("gameCreationDate")]
        public string GameCreationDate { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
        [JsonProperty("teamId")]
        public long TeamId { get; set; }
    }
}
