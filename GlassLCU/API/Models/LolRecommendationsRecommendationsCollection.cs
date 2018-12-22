using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
