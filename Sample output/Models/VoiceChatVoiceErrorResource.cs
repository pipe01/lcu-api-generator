using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class VoiceChatVoiceErrorResource
    {
        [JsonProperty("errorString")]
        public string ErrorString { get; set; }
        [JsonProperty("responseType")]
        public long ResponseType { get; set; }
        [JsonProperty("responseTypeString")]
        public string ResponseTypeString { get; set; }
        [JsonProperty("returnCode")]
        public long ReturnCode { get; set; }
        [JsonProperty("statusCode")]
        public long StatusCode { get; set; }
        [JsonProperty("statusString")]
        public string StatusString { get; set; }
    }
}
