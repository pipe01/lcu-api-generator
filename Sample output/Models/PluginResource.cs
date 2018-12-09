using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PluginResource
    {
        [JsonProperty("app")]
        public string App { get; set; }
        [JsonProperty("assetBundleNames")]
        public string[] AssetBundleNames { get; set; }
        [JsonProperty("dependencies")]
        public PluginResourceContract[] Dependencies { get; set; }
        [JsonProperty("dynLibFileName")]
        public string DynLibFileName { get; set; }
        [JsonProperty("dynLibPath")]
        public string DynLibPath { get; set; }
        [JsonProperty("externalUri")]
        public string ExternalUri { get; set; }
        [JsonProperty("feature")]
        public string Feature { get; set; }
        [JsonProperty("fullName")]
        public string FullName { get; set; }
        [JsonProperty("implementedContracts")]
        public PluginResourceContract[] ImplementedContracts { get; set; }
        [JsonProperty("isDynamicLibraryInited")]
        public bool IsDynamicLibraryInited { get; set; }
        [JsonProperty("isDynamicLibraryLoaded")]
        public bool IsDynamicLibraryLoaded { get; set; }
        [JsonProperty("mountedAssetBundles")]
        public object MountedAssetBundles { get; set; }
        [JsonProperty("orderDynamicLibraryInited")]
        public int OrderDynamicLibraryInited { get; set; }
        [JsonProperty("orderDynamicLibraryLoaded")]
        public int OrderDynamicLibraryLoaded { get; set; }
        [JsonProperty("orderWADFileMounted")]
        public int OrderWADFileMounted { get; set; }
        [JsonProperty("pluginInfoApiSemVer")]
        public string PluginInfoApiSemVer { get; set; }
        [JsonProperty("shortName")]
        public string ShortName { get; set; }
        [JsonProperty("standalone")]
        public bool Standalone { get; set; }
        [JsonProperty("subtype")]
        public string Subtype { get; set; }
        [JsonProperty("supertype")]
        public string Supertype { get; set; }
        [JsonProperty("threadingModel")]
        public string ThreadingModel { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}