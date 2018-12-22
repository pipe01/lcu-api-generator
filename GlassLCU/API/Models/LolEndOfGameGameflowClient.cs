using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEndOfGameGameflowClient
    {
        [JsonProperty("observerServerIp")]
        public string ObserverServerIp { get; set; }
        [JsonProperty("observerServerPort")]
        public int ObserverServerPort { get; set; }
        [JsonProperty("running")]
        public bool Running { get; set; }
    }
}
