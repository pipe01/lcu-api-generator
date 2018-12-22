using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PlayerLootDefinitionsDTO
    {
        [JsonProperty("lootItemList")]
        public LootItemListClientDTO LootItemList { get; set; }
        [JsonProperty("playerLoot")]
        public PlayerLootDTO[] PlayerLoot { get; set; }
        [JsonProperty("queryResult")]
        public QueryResultDTO QueryResult { get; set; }
        [JsonProperty("recipeList")]
        public LootLcdsRecipeListClientDTO RecipeList { get; set; }
    }
}
