using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootCollectionsWardSkin
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("ownership")]
        public LolLootCollectionsOwnership Ownership { get; set; }
        [JsonProperty("wardImagePath")]
        public string WardImagePath { get; set; }
        [JsonProperty("wardShadowImagePath")]
        public string WardShadowImagePath { get; set; }
    }
}
