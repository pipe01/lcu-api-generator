using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPremadeVoiceGameflowGameClient
    {
        [JsonProperty("running")]
        public bool Running { get; set; }
    }
}
