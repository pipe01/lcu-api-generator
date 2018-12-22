using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PluginManagerResource
    {
        [JsonProperty("state")]
        public PluginManagerState State { get; set; }
    }
}
