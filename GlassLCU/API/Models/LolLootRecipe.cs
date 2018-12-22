using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootRecipe
    {
        [JsonProperty("contextMenuText")]
        public string ContextMenuText { get; set; }
        [JsonProperty("crafterName")]
        public string CrafterName { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("displayCategories")]
        public string DisplayCategories { get; set; }
        [JsonProperty("imagePath")]
        public string ImagePath { get; set; }
        [JsonProperty("introVideoPath")]
        public string IntroVideoPath { get; set; }
        [JsonProperty("loopVideoPath")]
        public string LoopVideoPath { get; set; }
        [JsonProperty("metadata")]
        public LolLootRecipeMetadata Metadata { get; set; }
        [JsonProperty("outputs")]
        public LolLootRecipeOutput[] Outputs { get; set; }
        [JsonProperty("outroVideoPath")]
        public string OutroVideoPath { get; set; }
        [JsonProperty("recipeName")]
        public string RecipeName { get; set; }
        [JsonProperty("requirementText")]
        public string RequirementText { get; set; }
        [JsonProperty("slots")]
        public LolLootRecipeSlot[] Slots { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
