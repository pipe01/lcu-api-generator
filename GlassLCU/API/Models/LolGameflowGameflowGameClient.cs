using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGameflowGameflowGameClient
    {
        [JsonProperty("observerServerIp")]
        public string ObserverServerIp { get; set; }
        [JsonProperty("observerServerPort")]
        public int ObserverServerPort { get; set; }
        [JsonProperty("running")]
        public bool Running { get; set; }
        [JsonProperty("serverIp")]
        public string ServerIp { get; set; }
        [JsonProperty("serverPort")]
        public int ServerPort { get; set; }
        [JsonProperty("visible")]
        public bool Visible { get; set; }
    }
}
