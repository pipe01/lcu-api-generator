using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class GcloudVoiceChatPushToTalkResource
    {
        [JsonProperty("pttEnabled")]
        public bool PttEnabled { get; set; }
        [JsonProperty("pttKeyBinding")]
        public string PttKeyBinding { get; set; }
    }
}
