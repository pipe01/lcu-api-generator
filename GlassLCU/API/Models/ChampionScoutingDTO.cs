using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class ChampionScoutingDTO
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("gameCount")]
        public int GameCount { get; set; }
        [JsonProperty("kda")]
        public float Kda { get; set; }
        [JsonProperty("winCount")]
        public int WinCount { get; set; }
    }
}
