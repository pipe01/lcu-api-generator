using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolHonorV2GameflowSession
    {
        [JsonProperty("phase")]
        public LolHonorV2GameflowPhase Phase { get; set; }
    }
}
