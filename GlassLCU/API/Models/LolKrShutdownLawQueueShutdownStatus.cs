using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolKrShutdownLawQueueShutdownStatus
    {
        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }
    }
}
