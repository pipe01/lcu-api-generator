using Newtonsoft.Json;

namespace LCU_API_Generator
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
