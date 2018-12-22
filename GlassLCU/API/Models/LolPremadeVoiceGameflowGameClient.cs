using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPremadeVoiceGameflowGameClient
    {
        [JsonProperty("running")]
        public bool Running { get; set; }
    }
}
