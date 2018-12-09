using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolEndOfGameChampionMasteryMini
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("championLevel")]
        public long ChampionLevel { get; set; }
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
    }
}
