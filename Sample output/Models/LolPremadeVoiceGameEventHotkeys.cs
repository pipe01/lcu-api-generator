using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPremadeVoiceGameEventHotkeys
    {
        [JsonProperty("evtPushToTalk")]
        public string EvtPushToTalk { get; set; }
    }
}
