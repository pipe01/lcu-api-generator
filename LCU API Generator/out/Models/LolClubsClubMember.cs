using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsClubMember
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("role")]
        public LolClubsClubRole Role { get; set; }
        [JsonProperty("since")]
        public long Since { get; set; }
        [JsonProperty("summonerIconId")]
        public int SummonerIconId { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
    }
}
