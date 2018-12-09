using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LootItemListClientDTO
    {
        [JsonProperty("lastUpdate")]
        public long LastUpdate { get; set; }
        [JsonProperty("lootItems")]
        public LootItemClientDTO[] LootItems { get; set; }
    }
}
