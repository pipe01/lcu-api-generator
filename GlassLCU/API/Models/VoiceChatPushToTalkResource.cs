using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class VoiceChatPushToTalkResource
    {
        [JsonProperty("pttEnabled")]
        public bool PttEnabled { get; set; }
        [JsonProperty("pttKeyBinding")]
        public string PttKeyBinding { get; set; }
    }
}
