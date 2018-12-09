using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPremadeVoicePushToTalkResource
    {
        [JsonProperty("pttEnabled")]
        public bool PttEnabled { get; set; }
        [JsonProperty("pttKeyBinding")]
        public string PttKeyBinding { get; set; }
    }
}
