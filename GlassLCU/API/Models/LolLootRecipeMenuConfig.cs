using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
