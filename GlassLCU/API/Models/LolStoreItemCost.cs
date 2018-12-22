using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolStoreItemCost
    {
        [JsonProperty("cost")]
        public long Cost { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("discount")]
        public float Discount { get; set; }
    }
}
