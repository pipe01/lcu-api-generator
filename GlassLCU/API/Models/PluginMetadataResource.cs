using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PluginMetadataResource
    {
        [JsonProperty("app")]
        public string App { get; set; }
        [JsonProperty("feature")]
        public string Feature { get; set; }
        [JsonProperty("globalAssetBundles")]
        public string[] GlobalAssetBundles { get; set; }
        [JsonProperty("hasBundledAssets")]
        public bool HasBundledAssets { get; set; }
        [JsonProperty("implements")]
        public object Implements { get; set; }
        [JsonProperty("mock")]
        public string Mock { get; set; }
        [JsonProperty("perLocaleAssetBundles")]
        public object PerLocaleAssetBundles { get; set; }
        [JsonProperty("subtype")]
        public string Subtype { get; set; }
        [JsonProperty("threading")]
        public PluginThreadingModel Threading { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
