using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class BindingFullEnumValueHelp
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
