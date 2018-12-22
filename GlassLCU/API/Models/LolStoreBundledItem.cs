using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
