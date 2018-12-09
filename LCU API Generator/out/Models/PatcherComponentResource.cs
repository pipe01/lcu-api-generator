using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PatcherComponentResource
    {
        [JsonProperty("copy_to_solution")]
        public bool Copy_to_solution { get; set; }
        [JsonProperty("headers")]
        public PatcherHeaderEntry[] Headers { get; set; }
        [JsonProperty("history")]
        public PatcherComponentResourceHistory History { get; set; }
        [JsonProperty("hostname")]
        public string Hostname { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("install_dir")]
        public string Install_dir { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }
        [JsonProperty("remote_path")]
        public string Remote_path { get; set; }
        [JsonProperty("type")]
        public PatcherComponentResourceType Type { get; set; }
        [JsonProperty("use_tls")]
        public bool Use_tls { get; set; }
    }
}
