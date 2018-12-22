using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyPartyNotificationEnvelopeDto
    {
        [JsonProperty("player")]
        public LolLobbyPlayerDto Player { get; set; }
        [JsonProperty("queueRestriction")]
        public LolLobbyQueueRestrictionDto QueueRestriction { get; set; }
    }
}
