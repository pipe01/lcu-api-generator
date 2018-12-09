using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolReplaysReplaysDynamicConfig
    {
        [JsonProperty("MinSupportedGameServerVersion")]
        public string MinSupportedGameServerVersion { get; set; }
        [JsonProperty("MinutesUntilReplayConsideredLost")]
        public float MinutesUntilReplayConsideredLost { get; set; }
    }
}
