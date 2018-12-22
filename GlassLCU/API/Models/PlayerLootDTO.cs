using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PlayerLootDTO
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("expiryTime")]
        public long ExpiryTime { get; set; }
        [JsonProperty("lootName")]
        public string LootName { get; set; }
        [JsonProperty("refId")]
        public string RefId { get; set; }
    }
}