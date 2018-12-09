using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class ChampionMasteryPublicDTO
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("championLevel")]
        public int ChampionLevel { get; set; }
        [JsonProperty("championPoints")]
        public int ChampionPoints { get; set; }
    }
}