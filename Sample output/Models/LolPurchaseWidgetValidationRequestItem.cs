using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPurchaseWidgetValidationRequestItem
    {
        [JsonProperty("itemKey")]
        public LolPurchaseWidgetItemKey ItemKey { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
