//Auto-generated by https://github.com/pipe01/lcu-api-generator
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
