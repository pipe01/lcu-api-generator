using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyAutoFillQueueDto
    {
        [JsonProperty("autoFillEligible")]
        public bool AutoFillEligible { get; set; }
        [JsonProperty("autoFillProtectedForPromos")]
        public bool AutoFillProtectedForPromos { get; set; }
        [JsonProperty("autoFillProtectedForStreaking")]
        public bool AutoFillProtectedForStreaking { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
    }
}
