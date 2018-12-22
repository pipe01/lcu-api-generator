using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCatalogGameDataAugment
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("displayIcon")]
        public string DisplayIcon { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("guid")]
        public string Guid { get; set; }
    }
}