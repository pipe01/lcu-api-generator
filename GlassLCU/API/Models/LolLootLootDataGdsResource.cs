using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootLootDataGdsResource
    {
        [JsonProperty("LootBundles")]
        public LolLootLootBundleGdsResource[] LootBundles { get; set; }
        [JsonProperty("LootItems")]
        public LolLootLootItemGdsResource[] LootItems { get; set; }
        [JsonProperty("LootRecipes")]
        public LolLootLootRecipeGdsResource[] LootRecipes { get; set; }
        [JsonProperty("LootTables")]
        public LolLootLootTableGdsResource[] LootTables { get; set; }
    }
}
