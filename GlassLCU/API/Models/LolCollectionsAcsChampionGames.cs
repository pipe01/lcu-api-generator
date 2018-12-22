using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
