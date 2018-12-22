using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
