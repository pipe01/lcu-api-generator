//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPurchaseWidgetPurchaseItem
    {
        [JsonProperty("itemKey")]
        public LolPurchaseWidgetItemKey ItemKey { get; set; }
        [JsonProperty("purchaseCurrencyInfo")]
        public LolPurchaseWidgetItemPrice PurchaseCurrencyInfo { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; }
    }
}
