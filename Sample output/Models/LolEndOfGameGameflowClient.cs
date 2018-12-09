using Newtonsoft.Json;

namespace LCU_API_Generator
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
