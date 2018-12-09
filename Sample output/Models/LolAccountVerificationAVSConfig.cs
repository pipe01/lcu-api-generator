using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolAccountVerificationAVSConfig
    {
        [JsonProperty("Enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("PasswordEnabled")]
        public bool PasswordEnabled { get; set; }
    }
}
