using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PatcherHeaderEntry
    {
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
