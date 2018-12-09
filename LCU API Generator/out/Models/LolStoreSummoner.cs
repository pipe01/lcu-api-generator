using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolStoreSummoner
    {
        [JsonProperty("acctId")]
        public long AcctId { get; set; }
        [JsonProperty("sumId")]
        public long SumId { get; set; }
    }
}
