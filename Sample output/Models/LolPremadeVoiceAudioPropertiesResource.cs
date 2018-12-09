using Newtonsoft.Json;

namespace LCU_API_Generator
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
