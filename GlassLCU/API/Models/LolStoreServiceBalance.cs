using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolStoreServiceBalance
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
