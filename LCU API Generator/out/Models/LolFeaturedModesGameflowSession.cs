using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolFeaturedModesGameflowSession
    {
        [JsonProperty("phase")]
        public LolFeaturedModesGameflowPhase Phase { get; set; }
    }
}
