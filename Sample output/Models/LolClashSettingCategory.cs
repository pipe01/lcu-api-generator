using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashSettingCategory
    {
        [JsonProperty("data")]
        public object Data { get; set; }
        [JsonProperty("schemaVersion")]
        public int SchemaVersion { get; set; }
    }
}
