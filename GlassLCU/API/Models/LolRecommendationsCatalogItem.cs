using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRecommendationsCatalogItem
    {
        [JsonProperty("inventoryType")]
        public string InventoryType { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("itemRequirements")]
        public LolRecommendationsItemKey[] ItemRequirements { get; set; }
        [JsonProperty("maxQuantity")]
        public int MaxQuantity { get; set; }
        [JsonProperty("prices")]
        public LolRecommendationsItemCost[] Prices { get; set; }
        [JsonProperty("sale")]
        public LolRecommendationsSale Sale { get; set; }
        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }
}
