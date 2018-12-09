using Newtonsoft.Json;

namespace LCU_API_Generator
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
