using Newtonsoft.Json;

namespace LCU_API_Generator
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
