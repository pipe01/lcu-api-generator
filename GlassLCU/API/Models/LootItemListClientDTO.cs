using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
