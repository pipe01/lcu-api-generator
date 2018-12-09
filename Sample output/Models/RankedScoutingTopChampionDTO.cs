using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RankedScoutingTopChampionDTO
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("gameCount")]
        public int GameCount { get; set; }
        [JsonProperty("kda")]
        public float Kda { get; set; }
        [JsonProperty("rank")]
        public int Rank { get; set; }
        [JsonProperty("winCount")]
        public int WinCount { get; set; }
    }
}
