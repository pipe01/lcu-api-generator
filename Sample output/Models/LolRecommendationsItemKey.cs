using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRecommendationsItemKey
    {
        [JsonProperty("inventoryType")]
        public string InventoryType { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
    }
}