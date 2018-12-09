using Newtonsoft.Json;

namespace LCU_API_Generator
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
