using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPremadeVoiceGameInputSettings
    {
        [JsonProperty("GameEvents")]
        public LolPremadeVoiceGameEventHotkeys GameEvents { get; set; }
    }
}
