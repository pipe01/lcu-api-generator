using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolAccountVerificationSendTokenResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("smsTokenExpireDurationInSec")]
        public int SmsTokenExpireDurationInSec { get; set; }
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
