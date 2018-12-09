using Newtonsoft.Json;

namespace LCU_API_Generator
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
