using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCatalogItemLocalization
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("language")]
        public string Language { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
