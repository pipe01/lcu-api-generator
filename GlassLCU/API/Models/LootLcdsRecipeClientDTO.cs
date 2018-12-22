using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LootLcdsRecipeClientDTO
    {
        [JsonProperty("crafterName")]
        public string CrafterName { get; set; }
        [JsonProperty("displayCategories")]
        public string DisplayCategories { get; set; }
        [JsonProperty("metadata")]
        public LootLcdsRecipeMetadata Metadata { get; set; }
        [JsonProperty("outputs")]
        public LootLcdsRecipeOutputDTO[] Outputs { get; set; }
        [JsonProperty("recipeName")]
        public string RecipeName { get; set; }
        [JsonProperty("slots")]
        public LootLcdsRecipeSlotClientDTO[] Slots { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
