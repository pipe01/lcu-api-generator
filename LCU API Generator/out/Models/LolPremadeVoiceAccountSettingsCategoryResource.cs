using Newtonsoft.Json;

namespace LCU_API_Generator
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
