using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PluginLcdsResponse
    {
        [JsonProperty("body")]
        public object Body { get; set; }
        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }
}
