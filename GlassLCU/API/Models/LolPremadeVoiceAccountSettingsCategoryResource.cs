using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPremadeVoiceAccountSettingsCategoryResource
    {
        [JsonProperty("data")]
        public LolPremadeVoiceAccountSettingsCategoryDataResource Data { get; set; }
        [JsonProperty("schemaVersion")]
        public int SchemaVersion { get; set; }
    }
}
