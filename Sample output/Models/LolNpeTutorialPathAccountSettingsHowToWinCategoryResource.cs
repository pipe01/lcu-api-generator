using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathAccountSettingsHowToWinCategoryResource
    {
        [JsonProperty("data")]
        public LolNpeTutorialPathAccountSettingsHowToWinStats Data { get; set; }
        [JsonProperty("schemaVersion")]
        public int SchemaVersion { get; set; }
    }
}
