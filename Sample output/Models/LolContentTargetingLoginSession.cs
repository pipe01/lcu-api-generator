//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolContentTargetingLoginSession
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("state")]
        public LolContentTargetingLoginSessionState State { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
