//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPremadeVoiceAudioPropertiesResource
    {
        [JsonProperty("isLoopbackEnabled")]
        public bool IsLoopbackEnabled { get; set; }
        [JsonProperty("micEnergy")]
        public int MicEnergy { get; set; }
    }
}
