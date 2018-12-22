using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEndOfGameChampionMasteryGrade
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("grade")]
        public string Grade { get; set; }
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
    }
}
