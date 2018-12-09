using Newtonsoft.Json;

namespace LCU_API_Generator
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
