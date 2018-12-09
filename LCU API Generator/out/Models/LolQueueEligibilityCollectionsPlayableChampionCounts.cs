using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolQueueEligibilityCollectionsPlayableChampionCounts
    {
        [JsonProperty("championsOwned")]
        public int ChampionsOwned { get; set; }
    }
}
