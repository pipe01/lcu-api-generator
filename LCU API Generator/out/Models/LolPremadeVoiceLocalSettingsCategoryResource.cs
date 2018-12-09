using Newtonsoft.Json;

namespace LCU_API_Generator
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
