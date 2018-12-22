using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootPlayerLootNotification
    {
        [JsonProperty("acknowledged")]
        public bool Acknowledged { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}