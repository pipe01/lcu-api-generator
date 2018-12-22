using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
