using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class NetworkTestingNetworkExperimentsResource
    {
        [JsonProperty("experiments")]
        public object Experiments { get; set; }
    }
}
