using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class BindingFullTypeIdentifier
    {
        [JsonProperty("elementType")]
        public string ElementType { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
