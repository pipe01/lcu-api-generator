using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolKrShutdownLawShutdownLawNotification
    {
        [JsonProperty("type")]
        public LolKrShutdownLawShutdownLawStatus Type { get; set; }
    }
}
