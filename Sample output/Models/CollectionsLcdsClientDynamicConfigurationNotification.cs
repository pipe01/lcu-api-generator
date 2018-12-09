using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class CollectionsLcdsClientDynamicConfigurationNotification
    {
        [JsonProperty("configs")]
        public string Configs { get; set; }
        [JsonProperty("delta")]
        public bool Delta { get; set; }
    }
}
