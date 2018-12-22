using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPremadeVoiceStateResource
    {
        [JsonProperty("connected")]
        public bool Connected { get; set; }
    }
}
