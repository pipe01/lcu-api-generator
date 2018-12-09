using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMatchHistoryMatchHistoryList
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("games")]
        public LolMatchHistoryMatchHistoryGameList Games { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
    }
}
