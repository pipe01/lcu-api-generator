using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLoginRSOPlayerCredentials
    {
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
    }
}
