using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyEligibility
    {
        [JsonProperty("eligible")]
        public bool Eligible { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("restrictions")]
        public LolLobbyEligibilityRestriction[] Restrictions { get; set; }
    }
}
