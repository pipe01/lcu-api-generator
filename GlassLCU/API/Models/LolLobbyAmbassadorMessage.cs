using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyAmbassadorMessage
    {
        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
        [JsonProperty("httpStatus")]
        public int HttpStatus { get; set; }
        [JsonProperty("implementationDetails")]
        public string ImplementationDetails { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("payload")]
        public object Payload { get; set; }
    }
}