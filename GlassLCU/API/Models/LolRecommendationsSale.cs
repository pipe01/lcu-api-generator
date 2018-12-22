using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRecommendationsSale
    {
        [JsonProperty("endDate")]
        public string EndDate { get; set; }
        [JsonProperty("prices")]
        public LolRecommendationsItemCost[] Prices { get; set; }
        [JsonProperty("startDate")]
        public string StartDate { get; set; }
    }
}
