using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class BindingFullFieldHelp
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("offset")]
        public int Offset { get; set; }
        [JsonProperty("optional")]
        public bool Optional { get; set; }
        /// <summary>
        /// Describes the type of a value.
        /// </summary>
        [JsonProperty("type")]
        public BindingFullTypeIdentifier Type { get; set; }
    }
}
