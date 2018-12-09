using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLootRecipeMetadata
    {
        [JsonProperty("bonusDescriptions")]
        public LolLootLootDescription[] BonusDescriptions { get; set; }
        [JsonProperty("guaranteedDescriptions")]
        public LolLootLootDescription[] GuaranteedDescriptions { get; set; }
        [JsonProperty("tooltipsDisabled")]
        public bool TooltipsDisabled { get; set; }
    }
}
