using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
