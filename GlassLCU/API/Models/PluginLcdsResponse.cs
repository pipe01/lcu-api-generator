using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
