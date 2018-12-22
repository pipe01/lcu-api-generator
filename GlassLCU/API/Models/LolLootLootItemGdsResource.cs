using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootLootItemGdsResource
    {
        [JsonProperty("autoRedeem")]
        public bool AutoRedeem { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("endDate")]
        public string EndDate { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("image")]
        public string Image { get; set; }
        [JsonProperty("lifetimeMax")]
        public int LifetimeMax { get; set; }
        [JsonProperty("mappedStoreId")]
        public int MappedStoreId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("rarity")]
        public LolLootLootRarity Rarity { get; set; }
        [JsonProperty("recipeMenuActive")]
        public bool RecipeMenuActive { get; set; }
        [JsonProperty("recipeMenuSubtitle")]
        public string RecipeMenuSubtitle { get; set; }
        [JsonProperty("recipeMenuTitle")]
        public string RecipeMenuTitle { get; set; }
        [JsonProperty("startDate")]
        public string StartDate { get; set; }
        [JsonProperty("type")]
        public LolLootLootType Type { get; set; }
    }
}
