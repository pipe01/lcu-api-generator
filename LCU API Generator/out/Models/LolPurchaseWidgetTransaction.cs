using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPurchaseWidgetTransaction
    {
        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }
        [JsonProperty("itemKey")]
        public LolPurchaseWidgetItemKey ItemKey { get; set; }
        [JsonProperty("itemName")]
        public string ItemName { get; set; }
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }
}
