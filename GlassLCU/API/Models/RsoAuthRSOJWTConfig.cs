using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RsoAuthRSOJWTConfig
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
