using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPremadeVoiceLoginSession
    {
        [JsonProperty("connected")]
        public bool Connected { get; set; }
    }
}
