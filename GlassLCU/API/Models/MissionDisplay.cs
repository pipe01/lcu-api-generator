using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class MissionDisplay
    {
        [JsonProperty("attributes")]
        public string[] Attributes { get; set; }
    }
}
