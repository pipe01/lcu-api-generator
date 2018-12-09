using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLootLootTableGdsResource
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
