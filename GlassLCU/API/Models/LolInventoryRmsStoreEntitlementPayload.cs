using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
