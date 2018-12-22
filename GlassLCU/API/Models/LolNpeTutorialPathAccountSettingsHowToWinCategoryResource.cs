using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
