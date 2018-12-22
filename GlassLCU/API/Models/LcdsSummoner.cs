using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LcdsSummoner
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("sumId")]
        public long SumId { get; set; }
    }
}
