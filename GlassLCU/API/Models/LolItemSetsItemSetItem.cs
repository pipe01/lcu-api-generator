using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolItemSetsItemSetItem
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
