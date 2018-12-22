using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
