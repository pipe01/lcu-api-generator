using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCatalogSale
    {
        [JsonProperty("endDate")]
        public string EndDate { get; set; }
        [JsonProperty("prices")]
        public LolCatalogItemCost[] Prices { get; set; }
        [JsonProperty("startDate")]
        public string StartDate { get; set; }
    }
}
