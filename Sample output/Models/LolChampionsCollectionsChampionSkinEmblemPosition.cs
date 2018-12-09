using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampionsCollectionsChampionSkinEmblemPosition
    {
        [JsonProperty("horizontal")]
        public string Horizontal { get; set; }
        [JsonProperty("vertical")]
        public string Vertical { get; set; }
    }
}
