using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsCollectionsWardSkin
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("ownership")]
        public LolCollectionsCollectionsOwnership Ownership { get; set; }
        [JsonProperty("wardImagePath")]
        public string WardImagePath { get; set; }
        [JsonProperty("wardShadowImagePath")]
        public string WardShadowImagePath { get; set; }
    }
}
