using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPremadeVoiceGameInputSettings
    {
        [JsonProperty("GameEvents")]
        public LolPremadeVoiceGameEventHotkeys GameEvents { get; set; }
    }
}
