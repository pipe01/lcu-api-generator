using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolHeartbeatLoginSession
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("state")]
        public LolHeartbeatLoginSessionStates State { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
