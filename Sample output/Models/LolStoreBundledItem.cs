using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolStoreBundledItem
    {
        [JsonProperty("discountPrices")]
        public LolStoreBundledItemCost[] DiscountPrices { get; set; }
        [JsonProperty("inventoryType")]
        public string InventoryType { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
