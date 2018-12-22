using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEmailVerificationValidationStatus
    {
        [JsonProperty("emailStatus")]
        public string EmailStatus { get; set; }
    }
}
