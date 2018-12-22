using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PluginDescriptionResource
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("pluginDependencies")]
        public object PluginDependencies { get; set; }
        [JsonProperty("riotMeta")]
        public PluginMetadataResource RiotMeta { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}