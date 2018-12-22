using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class SanitizerContainsSanitizedResponse
    {
        [JsonProperty("contains")]
        public bool Contains { get; set; }
    }
}
