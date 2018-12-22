using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class ShutdownLcdsForcedClientShutdown
    {
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
