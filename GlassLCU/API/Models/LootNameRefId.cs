using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LootNameRefId
    {
        [JsonProperty("lootName")]
        public string LootName { get; set; }
        [JsonProperty("refId")]
        public string RefId { get; set; }
    }
}
