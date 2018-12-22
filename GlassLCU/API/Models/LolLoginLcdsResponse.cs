using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLoginLcdsResponse
    {
        [JsonProperty("body")]
        public object Body { get; set; }
        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }
}
