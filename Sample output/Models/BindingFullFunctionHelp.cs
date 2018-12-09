using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class BindingFullFunctionHelp
    {
        [JsonProperty("arguments")]
        public BindingFullArgumentHelp[] Arguments { get; set; }
        [JsonProperty("async")]
        public string Async { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("help")]
        public string Help { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("nameSpace")]
        public string NameSpace { get; set; }
        /// <summary>
        /// Describes the type of a value.
        /// </summary>
        [JsonProperty("returns")]
        public BindingFullTypeIdentifier Returns { get; set; }
        [JsonProperty("tags")]
        public string[] Tags { get; set; }
        [JsonProperty("threadSafe")]
        public bool ThreadSafe { get; set; }
    }
}
