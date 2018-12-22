using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRecommendationsAcsChampionGames
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("lane")]
        public string Lane { get; set; }
        [JsonProperty("queue")]
        public int Queue { get; set; }
        [JsonProperty("role")]
        public string Role { get; set; }
    }
}
