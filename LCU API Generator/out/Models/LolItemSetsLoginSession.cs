using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolItemSetsLoginSession
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("state")]
        public LolItemSetsLoginSessionStates State { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
