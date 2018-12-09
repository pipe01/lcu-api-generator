using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class NetworkTesting
    {
        public static Task<NetworkTestingNetworkExperimentsResource> GetNetworkTestingV1Experiments()
            => Sender.Request<NetworkTestingNetworkExperimentsResource>("get", $"/network-testing/v1/experiments");
        public static Task<NetworkTestingGameLatencyExperimentResults> GetNetworkTestingV1GameLatency()
            => Sender.Request<NetworkTestingGameLatencyExperimentResults>("get", $"/network-testing/v1/game-latency");
        public static Task DeleteNetworkTestingV1GameLatencyResults()
            => Sender.Request("delete", $"/network-testing/v1/game-latency/results");
    }
}
