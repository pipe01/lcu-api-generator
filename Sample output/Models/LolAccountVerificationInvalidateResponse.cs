//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolAccountVerificationInvalidateResponse
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
