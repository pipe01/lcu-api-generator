//Auto-generated by https://github.com/pipe01/lcu-api-generator
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
