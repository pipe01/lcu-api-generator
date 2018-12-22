using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
