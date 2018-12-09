using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRankedLoginSession
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("state")]
        public LolRankedLoginSessionStates State { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
