using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
