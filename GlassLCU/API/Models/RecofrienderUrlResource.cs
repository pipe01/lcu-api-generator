using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RecofrienderUrlResource
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
