using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolQueueEligibilityCollectionsPlayableChampionCounts
    {
        [JsonProperty("championsOwned")]
        public int ChampionsOwned { get; set; }
    }
}
