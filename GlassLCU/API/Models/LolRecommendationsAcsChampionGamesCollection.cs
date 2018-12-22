using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRecommendationsAcsChampionGamesCollection
    {
        [JsonProperty("champions")]
        public LolRecommendationsAcsChampionGames[] Champions { get; set; }
        [JsonProperty("gameCount")]
        public int GameCount { get; set; }
    }
}
