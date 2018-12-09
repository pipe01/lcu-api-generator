using Newtonsoft.Json;

namespace LCU_API_Generator
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
