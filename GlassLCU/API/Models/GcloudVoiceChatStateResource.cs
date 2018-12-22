using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class GcloudVoiceChatStateResource
    {
        [JsonProperty("connected")]
        public bool Connected { get; set; }
    }
}
