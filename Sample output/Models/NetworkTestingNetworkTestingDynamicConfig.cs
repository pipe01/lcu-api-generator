using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class NetworkTestingNetworkTestingDynamicConfig
    {
        [JsonProperty("GameLatencyProbability")]
        public float GameLatencyProbability { get; set; }
        [JsonProperty("GameLatencyProbeCount")]
        public int GameLatencyProbeCount { get; set; }
        [JsonProperty("GameLatencyProbePort")]
        public int GameLatencyProbePort { get; set; }
        [JsonProperty("GameLatencyProbeServers")]
        public string GameLatencyProbeServers { get; set; }
        [JsonProperty("GameLatencyProbeSize")]
        public int GameLatencyProbeSize { get; set; }
        [JsonProperty("GameLatencyTimeoutSecs")]
        public float GameLatencyTimeoutSecs { get; set; }
        [JsonProperty("IPv4OptionsProbability")]
        public float IPv4OptionsProbability { get; set; }
        [JsonProperty("IPv4OptionsProbeCount")]
        public int IPv4OptionsProbeCount { get; set; }
        [JsonProperty("IPv4OptionsProbePort")]
        public int IPv4OptionsProbePort { get; set; }
        [JsonProperty("IPv4OptionsProbeServers")]
        public string IPv4OptionsProbeServers { get; set; }
        [JsonProperty("IPv6SupportProbability")]
        public float IPv6SupportProbability { get; set; }
        [JsonProperty("IPv6SupportProbeCount")]
        public int IPv6SupportProbeCount { get; set; }
        [JsonProperty("IPv6SupportProbePort")]
        public int IPv6SupportProbePort { get; set; }
        [JsonProperty("IPv6SupportProbeServers")]
        public string IPv6SupportProbeServers { get; set; }
    }
}
