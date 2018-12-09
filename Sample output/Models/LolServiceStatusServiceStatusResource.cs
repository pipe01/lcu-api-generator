using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolServiceStatusServiceStatusResource
    {
        [JsonProperty("humanReadableUrl")]
        public string HumanReadableUrl { get; set; }
        [JsonProperty("status")]
        public LolServiceStatusServiceStatusResource_Status Status { get; set; }
    }
}
