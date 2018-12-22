using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootRecipeOutput
    {
        [JsonProperty("lootName")]
        public string LootName { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
