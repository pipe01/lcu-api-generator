using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
