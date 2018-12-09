using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolWorldsTokenCardInventoryItem
    {
        [JsonProperty("inventoryType")]
        public string InventoryType { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("ownershipType")]
        public LolWorldsTokenCardItemOwnershipType OwnershipType { get; set; }
        [JsonProperty("purchaseDate")]
        public string PurchaseDate { get; set; }
        [JsonProperty("quantity")]
        public long Quantity { get; set; }
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }
}