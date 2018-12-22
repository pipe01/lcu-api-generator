using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
