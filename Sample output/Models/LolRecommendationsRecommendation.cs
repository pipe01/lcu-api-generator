using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRecommendationsRecommendation
    {
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("itemType")]
        public LolRecommendationsItemType ItemType { get; set; }
    }
}
