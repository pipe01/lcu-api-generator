using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class BindingFullEventHelp
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("nameSpace")]
        public string NameSpace { get; set; }
        [JsonProperty("tags")]
        public string[] Tags { get; set; }
        /// <summary>
        /// Describes the type of a value.
        /// </summary>
        [JsonProperty("type")]
        public BindingFullTypeIdentifier Type { get; set; }
    }
}
