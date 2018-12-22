using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RecofrienderLinkResource
    {
        [JsonProperty("linked")]
        public bool Linked { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
