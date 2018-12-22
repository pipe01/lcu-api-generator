using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPurchaseWidgetValidationResponseItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("itemKey")]
        public LolPurchaseWidgetItemKey ItemKey { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("prices")]
        public LolPurchaseWidgetItemPrice[] Prices { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("sale")]
        public LolPurchaseWidgetSale Sale { get; set; }
    }
}
