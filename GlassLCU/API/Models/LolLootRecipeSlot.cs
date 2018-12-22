using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootRecipeSlot
    {
        [JsonProperty("lootIds")]
        public string[] LootIds { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("slotNumber")]
        public int SlotNumber { get; set; }
        [JsonProperty("tags")]
        public string Tags { get; set; }
    }
}
