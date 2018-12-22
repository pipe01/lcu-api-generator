using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMatchHistoryMatchHistoryPlayerPlatformDelta
    {
        [JsonProperty("compensationModeEnabled")]
        public bool CompensationModeEnabled { get; set; }
        [JsonProperty("ipDelta")]
        public long IpDelta { get; set; }
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
        [JsonProperty("xpDelta")]
        public long XpDelta { get; set; }
    }
}
