using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolHonorV2ServiceProxyRetrieveProfileResponse
    {
        [JsonProperty("checkpoint")]
        public int Checkpoint { get; set; }
        [JsonProperty("honorLevel")]
        public int HonorLevel { get; set; }
        [JsonProperty("rewardsLocked")]
        public bool RewardsLocked { get; set; }
    }
}
