using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsAcsChampionGames
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("queue")]
        public int Queue { get; set; }
    }
}
