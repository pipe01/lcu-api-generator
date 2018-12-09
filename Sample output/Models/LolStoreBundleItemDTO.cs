using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolStoreBundleItemDTO
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("discountedRp")]
        public long DiscountedRp { get; set; }
        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }
        [JsonProperty("inventoryType")]
        public string InventoryType { get; set; }
        [JsonProperty("ip")]
        public long Ip { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("owned")]
        public bool Owned { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("rp")]
        public long Rp { get; set; }
    }
}
