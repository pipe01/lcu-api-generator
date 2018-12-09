using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolHonorV2GameflowSession
    {
        [JsonProperty("phase")]
        public LolHonorV2GameflowPhase Phase { get; set; }
    }
}
