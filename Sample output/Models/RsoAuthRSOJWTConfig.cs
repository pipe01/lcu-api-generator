using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RsoAuthRSOJWTConfig
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
