using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
