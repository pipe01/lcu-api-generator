using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PatcherChunkingPatcherEnvironment
    {
        [JsonProperty("components")]
        public string[] Components { get; set; }
    }
}
