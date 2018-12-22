using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PluginResourceContract
    {
        [JsonProperty("fullName")]
        public string FullName { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
