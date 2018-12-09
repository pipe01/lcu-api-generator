using Newtonsoft.Json;

namespace LCU_API_Generator
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
