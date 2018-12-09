using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsClubPlayer
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("summonerIconId")]
        public int SummonerIconId { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
    }
}
