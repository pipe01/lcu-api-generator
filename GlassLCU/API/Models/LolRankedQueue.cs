using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRankedQueue
    {
        [JsonProperty("type")]
        public object Type { get; set; }
    }
}
