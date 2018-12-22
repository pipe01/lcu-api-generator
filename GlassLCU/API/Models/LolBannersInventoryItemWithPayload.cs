using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolBannersInventoryItemWithPayload
    {
        [JsonProperty("inventoryType")]
        public string InventoryType { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("payload")]
        public object Payload { get; set; }
        [JsonProperty("purchaseDate")]
        public string PurchaseDate { get; set; }
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }
}