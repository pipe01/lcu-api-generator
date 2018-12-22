using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class NetworkTestingNetworkExperimentResource
    {
        [JsonProperty("status")]
        public NetworkTestingNetworkExperimentStatus Status { get; set; }
    }
}
