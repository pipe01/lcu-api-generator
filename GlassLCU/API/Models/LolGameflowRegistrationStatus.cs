using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGameflowRegistrationStatus
    {
        [JsonProperty("complete")]
        public bool Complete { get; set; }
        [JsonProperty("errorCodes")]
        public string[] ErrorCodes { get; set; }
    }
}
