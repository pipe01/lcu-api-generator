using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMapsTutorialCard
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("footer")]
        public string Footer { get; set; }
        [JsonProperty("header")]
        public string Header { get; set; }
        [JsonProperty("imagePath")]
        public string ImagePath { get; set; }
    }
}
