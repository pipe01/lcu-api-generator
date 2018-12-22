using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolStoreItemLocalization
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("language")]
        public string Language { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
