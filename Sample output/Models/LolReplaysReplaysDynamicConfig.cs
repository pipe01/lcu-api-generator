//Auto-generated by https://github.com/pipe01/lcu-api-generator
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
