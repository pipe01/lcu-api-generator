using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class NetworkTestingNetworkExperimentsResource
    {
        [JsonProperty("experiments")]
        public object Experiments { get; set; }
    }
}
