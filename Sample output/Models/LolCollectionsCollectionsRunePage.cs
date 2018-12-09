using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsCollectionsRunePage
    {
        [JsonProperty("current")]
        public bool Current { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("runes")]
        public LolCollectionsCollectionsRune[] Runes { get; set; }
    }
}
