using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMatchHistoryMatchHistoryParticipantIdentities
    {
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }
        [JsonProperty("player")]
        public LolMatchHistoryMatchHistoryParticipantIdentityPlayer Player { get; set; }
    }
}
