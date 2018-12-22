using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootContextMenu
    {
        [JsonProperty("actionType")]
        public string ActionType { get; set; }
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("essenceQuantity")]
        public int EssenceQuantity { get; set; }
        [JsonProperty("essenceType")]
        public string EssenceType { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("recipeContextMenuAction")]
        public string RecipeContextMenuAction { get; set; }
        [JsonProperty("recipeDescription")]
        public string RecipeDescription { get; set; }
        [JsonProperty("requiredOthers")]
        public string RequiredOthers { get; set; }
        [JsonProperty("requiredOthersCount")]
        public int RequiredOthersCount { get; set; }
        [JsonProperty("requiredOthersName")]
        public string RequiredOthersName { get; set; }
        [JsonProperty("requiredTokens")]
        public string RequiredTokens { get; set; }
    }
}