//Auto-generated by https://github.com/pipe01/lcu-api-generator
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
