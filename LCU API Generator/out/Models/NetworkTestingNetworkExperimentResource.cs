using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class NetworkTestingNetworkExperimentResource
    {
        [JsonProperty("status")]
        public NetworkTestingNetworkExperimentStatus Status { get; set; }
    }
}
