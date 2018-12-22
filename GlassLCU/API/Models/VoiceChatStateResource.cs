using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class VoiceChatStateResource
    {
        [JsonProperty("connected")]
        public bool Connected { get; set; }
    }
}
