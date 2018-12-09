using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampionsCollectionsChampionSkinEmblemPath
    {
        [JsonProperty("large")]
        public string Large { get; set; }
        [JsonProperty("small")]
        public string Small { get; set; }
    }
}
