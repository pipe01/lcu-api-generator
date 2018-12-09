using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolEmailVerificationRemoteEmailVerificationSession
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("emailVerified")]
        public bool EmailVerified { get; set; }
    }
}
