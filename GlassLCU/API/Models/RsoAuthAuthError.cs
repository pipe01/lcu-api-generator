using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RsoAuthAuthError
    {
        [JsonProperty("error")]
        public string Error { get; set; }
        [JsonProperty("errorDescription")]
        public string ErrorDescription { get; set; }
    }
}
