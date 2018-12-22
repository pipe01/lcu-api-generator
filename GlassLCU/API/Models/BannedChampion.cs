using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
