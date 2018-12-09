using Newtonsoft.Json;

namespace LCU_API_Generator
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
