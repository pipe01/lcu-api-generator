using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathAccountSettingsCategoryResource
    {
        [JsonProperty("data")]
        public LolNpeTutorialPathAccountSettingsTutorial Data { get; set; }
        [JsonProperty("schemaVersion")]
        public int SchemaVersion { get; set; }
    }
}
