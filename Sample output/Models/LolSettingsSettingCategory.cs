using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSettingsSettingCategory
    {
        [JsonProperty("data")]
        public object Data { get; set; }
        [JsonProperty("schemaVersion")]
        public int SchemaVersion { get; set; }
    }
}
