using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class NetworkTestingGameLatencyExperimentResult
    {
        [JsonProperty("latency")]
        public float Latency { get; set; }
        [JsonProperty("server")]
        public string Server { get; set; }
        [JsonProperty("size")]
        public int Size { get; set; }
    }
}