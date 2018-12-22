using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEsportStreamNotificationsGameflowSession
    {
        [JsonProperty("phase")]
        public LolEsportStreamNotificationsGameflowPhase Phase { get; set; }
    }
}
