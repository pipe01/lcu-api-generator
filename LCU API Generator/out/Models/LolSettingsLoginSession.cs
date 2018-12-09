using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSettingsLoginSession
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("gasToken")]
        public object GasToken { get; set; }
        [JsonProperty("state")]
        public LolSettingsLoginSessionStates State { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
