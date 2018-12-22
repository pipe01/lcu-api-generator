using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolAcsAcsChampionGamesCollection
    {
        [JsonProperty("champions")]
        public LolAcsAcsChampionGames[] Champions { get; set; }
        [JsonProperty("gameCount")]
        public int GameCount { get; set; }
    }
}
