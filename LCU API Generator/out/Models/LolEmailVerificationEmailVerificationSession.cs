using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolEmailVerificationEmailVerificationSession
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("emailVerified")]
        public bool EmailVerified { get; set; }
        [JsonProperty("fatalError")]
        public bool FatalError { get; set; }
    }
}
