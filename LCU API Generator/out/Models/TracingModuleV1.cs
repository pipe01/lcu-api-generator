using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class TracingModuleV1
    {
        [JsonProperty("moduleId")]
        public int ModuleId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("threadingModel")]
        public TracingModuleThreadingModelV1 ThreadingModel { get; set; }
        [JsonProperty("type")]
        public TracingModuleTypeV1 Type { get; set; }
    }
}
