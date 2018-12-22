using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolQueueEligibilityChampionPlayableCountsForEligibility
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
