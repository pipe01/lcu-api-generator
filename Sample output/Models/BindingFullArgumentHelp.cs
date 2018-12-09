using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class BindingFullArgumentHelp
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("optional")]
        public bool Optional { get; set; }
        /// <summary>
        /// Describes the type of a value.
        /// </summary>
        [JsonProperty("type")]
        public BindingFullTypeIdentifier Type { get; set; }
    }
}
