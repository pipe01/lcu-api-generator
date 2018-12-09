using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPersonalizedOffersOfferRequest
    {
        [JsonProperty("inventoryType")]
        public string InventoryType { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("offerId")]
        public string OfferId { get; set; }
        [JsonProperty("price")]
        public long Price { get; set; }
    }
}
