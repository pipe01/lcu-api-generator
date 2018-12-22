using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
