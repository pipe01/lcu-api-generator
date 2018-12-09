using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPremadeVoiceStateResource
    {
        [JsonProperty("connected")]
        public bool Connected { get; set; }
    }
}
