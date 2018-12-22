using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolItemSetsPreferredItemSlot
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("preferredItemSlot")]
        public int PreferredItemSlot { get; set; }
    }
}