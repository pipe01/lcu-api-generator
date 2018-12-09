using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class SanitizerContainsSanitizedResponse
    {
        [JsonProperty("contains")]
        public bool Contains { get; set; }
    }
}
