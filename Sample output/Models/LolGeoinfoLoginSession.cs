using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolGeoinfoLoginSession
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("state")]
        public LolGeoinfoLoginSessionState State { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
