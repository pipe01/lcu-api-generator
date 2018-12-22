using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCatalogInventoryContent
    {
        [JsonProperty("itemId")]
        public long ItemId { get; set; }
        [JsonProperty("ownershipType")]
        public LolCatalogInventoryOwnership OwnershipType { get; set; }
        [JsonProperty("purchaseDate")]
        public string PurchaseDate { get; set; }
    }
}
