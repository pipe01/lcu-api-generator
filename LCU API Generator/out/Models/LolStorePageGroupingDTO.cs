using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolStorePageGroupingDTO
    {
        [JsonProperty("grouped")]
        public bool Grouped { get; set; }
        [JsonProperty("hidden")]
        public bool Hidden { get; set; }
        [JsonProperty("items")]
        public LolStoreItemKey[] Items { get; set; }
    }
}
