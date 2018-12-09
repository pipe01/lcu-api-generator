using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsGameDataChampionMasteries
    {
        [JsonProperty("tree")]
        public LolCollectionsGameDataChampionMasteryTree Tree { get; set; }
    }
}
