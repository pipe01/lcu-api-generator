using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PatcherChunkingPatcherEnvironment
    {
        [JsonProperty("components")]
        public string[] Components { get; set; }
    }
}
