using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPlayerBehaviorPlayerBehavior_GameflowSessionResource
    {
        [JsonProperty("phase")]
        public LolPlayerBehaviorGameflowPhase Phase { get; set; }
    }
}
