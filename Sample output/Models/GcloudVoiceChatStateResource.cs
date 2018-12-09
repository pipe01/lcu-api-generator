using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class GcloudVoiceChatStateResource
    {
        [JsonProperty("connected")]
        public bool Connected { get; set; }
    }
}
