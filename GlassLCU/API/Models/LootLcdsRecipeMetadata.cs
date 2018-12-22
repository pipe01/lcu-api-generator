using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LootLcdsRecipeMetadata
    {
        [JsonProperty("bonusDescriptions")]
        public LootLcdsLootDescriptionDTO[] BonusDescriptions { get; set; }
        [JsonProperty("guaranteedDescriptions")]
        public LootLcdsLootDescriptionDTO[] GuaranteedDescriptions { get; set; }
        [JsonProperty("tooltipsDisabled")]
        public bool TooltipsDisabled { get; set; }
    }
}
