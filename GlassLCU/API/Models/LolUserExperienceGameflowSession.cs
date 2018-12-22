using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolUserExperienceGameflowSession
    {
        [JsonProperty("phase")]
        public LolUserExperienceGameflowPhase Phase { get; set; }
    }
}
