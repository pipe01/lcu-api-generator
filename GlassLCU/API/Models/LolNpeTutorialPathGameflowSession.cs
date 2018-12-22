using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeTutorialPathGameflowSession
    {
        [JsonProperty("phase")]
        public LolNpeTutorialPathGameflowPhase Phase { get; set; }
    }
}
