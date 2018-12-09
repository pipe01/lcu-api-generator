using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolFeaturedModesLoginSession
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("state")]
        public LolFeaturedModesLoginSessionStates State { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
