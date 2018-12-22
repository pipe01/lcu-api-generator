using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
