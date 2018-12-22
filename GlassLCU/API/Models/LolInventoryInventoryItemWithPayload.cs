using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolInventoryInventoryItemWithPayload
    {
        [JsonProperty("inventoryType")]
        public string InventoryType { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("ownershipType")]
        public LolInventoryItemOwnershipType OwnershipType { get; set; }
        [JsonProperty("payload")]
        public object Payload { get; set; }
        [JsonProperty("purchaseDate")]
        public string PurchaseDate { get; set; }
        [JsonProperty("quantity")]
        public long Quantity { get; set; }
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }
}
