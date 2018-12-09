using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCatalogCatalogPluginPrice
    {
        [JsonProperty("cost")]
        public long Cost { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("sale")]
        public LolCatalogCatalogPluginSale Sale { get; set; }
    }
}
