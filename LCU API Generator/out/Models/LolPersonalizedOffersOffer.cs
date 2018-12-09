using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPersonalizedOffersOffer
    {
        [JsonProperty("discountPrice")]
        public long DiscountPrice { get; set; }
        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
        [JsonProperty("inventoryType")]
        public string InventoryType { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("offerId")]
        public string OfferId { get; set; }
        [JsonProperty("originalPrice")]
        public long OriginalPrice { get; set; }
        [JsonProperty("owned")]
        public bool Owned { get; set; }
        [JsonProperty("revealed")]
        public bool Revealed { get; set; }
        [JsonProperty("spotIndex")]
        public int SpotIndex { get; set; }
    }
}
