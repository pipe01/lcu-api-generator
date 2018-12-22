using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolKrShutdownLawAllQueueShutdownStatus
    {
        [JsonProperty("isAllQueuesDisabled")]
        public bool IsAllQueuesDisabled { get; set; }
    }
}
