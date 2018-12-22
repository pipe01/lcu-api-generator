using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCollectionsAcsChampionGamesCollection
    {
        [JsonProperty("champions")]
        public LolCollectionsAcsChampionGames[] Champions { get; set; }
        [JsonProperty("gameCount")]
        public int GameCount { get; set; }
    }
}
