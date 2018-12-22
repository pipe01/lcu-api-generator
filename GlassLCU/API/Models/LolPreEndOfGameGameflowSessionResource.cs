using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPreEndOfGameGameflowSessionResource
    {
        [JsonProperty("phase")]
        public LolPreEndOfGameGameflowPhase Phase { get; set; }
    }
}
