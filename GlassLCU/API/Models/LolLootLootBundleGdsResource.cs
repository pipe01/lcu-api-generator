using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootLootBundleGdsResource
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("descriptionLong")]
        public string DescriptionLong { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("image")]
        public string Image { get; set; }
    }
}
