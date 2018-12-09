using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPerksUISettings
    {
        [JsonProperty("gameplayPatchVersionSeen")]
        public string GameplayPatchVersionSeen { get; set; }
        [JsonProperty("gameplayUpdatedPerksSeen")]
        public int[] GameplayUpdatedPerksSeen { get; set; }
        [JsonProperty("gridModeEnabled")]
        public bool GridModeEnabled { get; set; }
        [JsonProperty("showLongDescriptions")]
        public bool ShowLongDescriptions { get; set; }
        [JsonProperty("showPresetPages")]
        public bool ShowPresetPages { get; set; }
    }
}