//Auto-generated by https://github.com/pipe01/lcu-api-generator
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
