using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolContentTargetingChampionGamesCollection
    {
        [JsonProperty("champions")]
        public LolContentTargetingChampionGames[] Champions { get; set; }
        [JsonProperty("gameCount")]
        public int GameCount { get; set; }
    }
}
