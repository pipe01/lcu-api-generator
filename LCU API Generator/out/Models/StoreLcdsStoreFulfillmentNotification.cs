using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class StoreLcdsStoreFulfillmentNotification
    {
        [JsonProperty("data")]
        public object Data { get; set; }
        [JsonProperty("inventoryType")]
        public string InventoryType { get; set; }
        [JsonProperty("ip")]
        public long Ip { get; set; }
        [JsonProperty("rp")]
        public long Rp { get; set; }
    }
}
