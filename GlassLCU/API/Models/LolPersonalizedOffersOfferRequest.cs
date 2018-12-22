using Newtonsoft.Json;

namespace GlassLCU.API.Models
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