using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashGameflowSession
    {
        [JsonProperty("phase")]
        public LolClashGameflowPhase Phase { get; set; }
    }
}
