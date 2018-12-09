using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class ActiveBoostsLcdsStoreFulfillmentNotification
    {
        [JsonProperty("data")]
        public object Data { get; set; }
        [JsonProperty("inventoryType")]
        public string InventoryType { get; set; }
    }
}
