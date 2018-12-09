using Newtonsoft.Json;

namespace LCU_API_Generator
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
