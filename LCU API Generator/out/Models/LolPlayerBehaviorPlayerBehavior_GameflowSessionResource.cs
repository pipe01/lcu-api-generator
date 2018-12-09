using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPlayerBehaviorPlayerBehavior_GameflowSessionResource
    {
        [JsonProperty("phase")]
        public LolPlayerBehaviorGameflowPhase Phase { get; set; }
    }
}
