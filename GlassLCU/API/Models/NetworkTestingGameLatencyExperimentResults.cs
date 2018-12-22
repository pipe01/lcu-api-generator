using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class NetworkTestingGameLatencyExperimentResults
    {
        [JsonProperty("results")]
        public NetworkTestingGameLatencyExperimentResult[] Results { get; set; }
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }
}
