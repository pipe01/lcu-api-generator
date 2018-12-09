using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCatalogCatalogPluginSale
    {
        [JsonProperty("cost")]
        public long Cost { get; set; }
        [JsonProperty("discount")]
        public float Discount { get; set; }
        [JsonProperty("endDate")]
        public string EndDate { get; set; }
        [JsonProperty("startDate")]
        public string StartDate { get; set; }
    }
}
