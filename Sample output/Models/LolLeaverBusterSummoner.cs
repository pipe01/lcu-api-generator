using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLeaverBusterSummoner
    {
        [JsonProperty("acctId")]
        public long AcctId { get; set; }
        [JsonProperty("sumId")]
        public long SumId { get; set; }
    }
}
