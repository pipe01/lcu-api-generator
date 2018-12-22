using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPerksChampionPreferredStyle
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("championName")]
        public string ChampionName { get; set; }
        [JsonProperty("style")]
        public int Style { get; set; }
    }
}
