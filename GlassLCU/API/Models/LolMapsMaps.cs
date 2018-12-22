using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMapsMaps
    {
        [JsonProperty("assets")]
        public object Assets { get; set; }
        [JsonProperty("categorizedContentBundles")]
        public object CategorizedContentBundles { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("gameModeDescription")]
        public string GameModeDescription { get; set; }
        [JsonProperty("gameModeName")]
        public string GameModeName { get; set; }
        [JsonProperty("gameModeShortName")]
        public string GameModeShortName { get; set; }
        [JsonProperty("gameMutator")]
        public string GameMutator { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }
        [JsonProperty("isRGM")]
        public bool IsRGM { get; set; }
        [JsonProperty("mapStringId")]
        public string MapStringId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
        [JsonProperty("platformName")]
        public string PlatformName { get; set; }
        [JsonProperty("properties")]
        public object Properties { get; set; }
        [JsonProperty("tutorialCards")]
        public LolMapsTutorialCard[] TutorialCards { get; set; }
    }
}
