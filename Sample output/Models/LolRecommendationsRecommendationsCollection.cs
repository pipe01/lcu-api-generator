using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRecommendationsRecommendationsCollection
    {
        [JsonProperty("recommendations")]
        public LolRecommendationsRecommendation[] Recommendations { get; set; }
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }
}
