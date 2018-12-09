using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsGameDataChampionMasteryTree
    {
        [JsonProperty("groups")]
        public LolCollectionsGameDataChampionMasteryGroup[] Groups { get; set; }
    }
}
