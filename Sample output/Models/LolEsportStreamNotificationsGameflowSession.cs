using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolEsportStreamNotificationsGameflowSession
    {
        [JsonProperty("phase")]
        public LolEsportStreamNotificationsGameflowPhase Phase { get; set; }
    }
}
