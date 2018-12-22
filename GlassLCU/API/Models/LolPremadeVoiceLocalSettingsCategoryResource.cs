using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPremadeVoiceLocalSettingsCategoryResource
    {
        [JsonProperty("data")]
        public LolPremadeVoiceLocalSettingsCategoryDataResource Data { get; set; }
        [JsonProperty("schemaVersion")]
        public int SchemaVersion { get; set; }
    }
}
