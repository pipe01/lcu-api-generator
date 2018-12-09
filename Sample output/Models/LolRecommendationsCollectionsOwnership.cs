using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRecommendationsCollectionsOwnership
    {
        [JsonProperty("freeToPlayReward")]
        public bool FreeToPlayReward { get; set; }
        [JsonProperty("owned")]
        public bool Owned { get; set; }
    }
}
