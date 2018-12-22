using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RecofrienderContactCountResource
    {
        [JsonProperty("count")]
        public long Count { get; set; }
    }
}
