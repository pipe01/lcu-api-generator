using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRecommendationsMatchHistoryList
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("games")]
        public LolRecommendationsMatchHistoryGameList Games { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
    }
}
