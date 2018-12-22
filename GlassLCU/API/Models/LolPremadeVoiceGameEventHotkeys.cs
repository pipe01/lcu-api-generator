using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPremadeVoiceGameEventHotkeys
    {
        [JsonProperty("evtPushToTalk")]
        public string EvtPushToTalk { get; set; }
    }
}
