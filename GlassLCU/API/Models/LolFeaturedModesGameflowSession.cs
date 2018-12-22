using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolFeaturedModesGameflowSession
    {
        [JsonProperty("phase")]
        public LolFeaturedModesGameflowPhase Phase { get; set; }
    }
}
