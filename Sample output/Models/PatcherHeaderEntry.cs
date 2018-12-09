using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PatcherHeaderEntry
    {
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
