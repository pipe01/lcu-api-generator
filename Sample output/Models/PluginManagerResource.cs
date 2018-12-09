using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PluginManagerResource
    {
        [JsonProperty("state")]
        public PluginManagerState State { get; set; }
    }
}
