using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class GcloudVoiceChatUpdateParticipantResource
    {
        [JsonProperty("isMuted")]
        public bool IsMuted { get; set; }
        [JsonProperty("volume")]
        public int Volume { get; set; }
    }
}
