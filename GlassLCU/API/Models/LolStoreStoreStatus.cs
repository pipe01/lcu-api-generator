using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolStoreStoreStatus
    {
        [JsonProperty("storefrontIsRunning")]
        public bool StorefrontIsRunning { get; set; }
    }
}
