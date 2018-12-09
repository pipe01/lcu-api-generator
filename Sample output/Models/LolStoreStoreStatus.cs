using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolStoreStoreStatus
    {
        [JsonProperty("storefrontIsRunning")]
        public bool StorefrontIsRunning { get; set; }
    }
}
