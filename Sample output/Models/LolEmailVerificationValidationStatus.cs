using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolEmailVerificationValidationStatus
    {
        [JsonProperty("emailStatus")]
        public string EmailStatus { get; set; }
    }
}
