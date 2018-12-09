using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLootRecipeMenuConfig
    {
        [JsonProperty("alwaysShowLootIds")]
        public string[] AlwaysShowLootIds { get; set; }
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("lootItemsUsingBreakoutRecipeMenu")]
        public string[] LootItemsUsingBreakoutRecipeMenu { get; set; }
    }
}
