using Newtonsoft.Json;

namespace LCU_API_Generator
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
