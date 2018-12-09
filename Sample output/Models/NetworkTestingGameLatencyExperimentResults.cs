using Newtonsoft.Json;

namespace LCU_API_Generator
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
