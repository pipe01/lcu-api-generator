using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolContentTargetingContentTargetingFilterResponse
    {
        [JsonProperty("filters")]
        public string[] Filters { get; set; }
    }
}
