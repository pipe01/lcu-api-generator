//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRecommendationsMatchHistoryParticipantIdentityPlayer
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("currentAccountId")]
        public long CurrentAccountId { get; set; }
        [JsonProperty("currentPlatformId")]
        public string CurrentPlatformId { get; set; }
        [JsonProperty("matchHistoryUri")]
        public string MatchHistoryUri { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
        [JsonProperty("profileIcon")]
        public int ProfileIcon { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
    }
}
