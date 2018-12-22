using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolQueueEligibilityQueueShutdownStatus
    {
        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }
    }
}
