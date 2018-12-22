using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class BindingFullApiHelp
    {
        [JsonProperty("events")]
        public BindingFullEventHelp[] Events { get; set; }
        [JsonProperty("functions")]
        public BindingFullFunctionHelp[] Functions { get; set; }
        [JsonProperty("types")]
        public BindingFullTypeHelp[] Types { get; set; }
    }
}
