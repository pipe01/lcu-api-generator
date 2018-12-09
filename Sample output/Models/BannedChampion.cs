using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class BannedChampion
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("pickTurn")]
        public int PickTurn { get; set; }
        [JsonProperty("teamId")]
        public int TeamId { get; set; }
    }
}
