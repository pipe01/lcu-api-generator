using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolHonorV2VendedHonorState
    {
        [JsonProperty("checkpoint")]
        public int Checkpoint { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("rewardsLocked")]
        public bool RewardsLocked { get; set; }
    }
}
