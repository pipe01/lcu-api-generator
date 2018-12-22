using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampionsCollectionsChampionPlayableCounts
    {
        [JsonProperty("championsFreeToPlay")]
        public int ChampionsFreeToPlay { get; set; }
        [JsonProperty("championsFreeToPlayReward")]
        public int ChampionsFreeToPlayReward { get; set; }
        [JsonProperty("championsOwned")]
        public int ChampionsOwned { get; set; }
        [JsonProperty("championsRented")]
        public int ChampionsRented { get; set; }
    }
}
