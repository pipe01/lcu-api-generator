using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRecommendationsCollectionsChampionMinimal
    {
        [JsonProperty("active")]
        public bool Active { get; set; }
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("ownership")]
        public LolRecommendationsCollectionsOwnership Ownership { get; set; }
        [JsonProperty("purchased")]
        public long Purchased { get; set; }
    }
}
