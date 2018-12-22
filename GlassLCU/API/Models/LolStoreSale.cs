using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolStoreSale
    {
        [JsonProperty("endDate")]
        public string EndDate { get; set; }
        [JsonProperty("prices")]
        public LolStoreItemCost[] Prices { get; set; }
        [JsonProperty("startDate")]
        public string StartDate { get; set; }
    }
}
