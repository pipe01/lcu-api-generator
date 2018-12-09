using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolStoreBundledItemCost
    {
        [JsonProperty("cost")]
        public long Cost { get; set; }
        [JsonProperty("costType")]
        public string CostType { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("discount")]
        public float Discount { get; set; }
    }
}
