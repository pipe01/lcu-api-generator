//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeTutorialPathParticipantIdentities
    {
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }
        [JsonProperty("player")]
        public LolNpeTutorialPathParticipantIdentityPlayer Player { get; set; }
    }
}
