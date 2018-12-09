using Newtonsoft.Json;

namespace LCU_API_Generator
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
