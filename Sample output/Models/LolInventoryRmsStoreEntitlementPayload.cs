using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolInventoryRmsStoreEntitlementPayload
    {
        [JsonProperty("items")]
        public LolInventoryRmsStoreEntitlementItem[] Items { get; set; }
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }
}
