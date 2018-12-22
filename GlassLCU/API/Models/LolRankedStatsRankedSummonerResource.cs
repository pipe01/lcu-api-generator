using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRankedStatsRankedSummonerResource
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
