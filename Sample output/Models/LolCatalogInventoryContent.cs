using Newtonsoft.Json;

namespace LCU_API_Generator
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
