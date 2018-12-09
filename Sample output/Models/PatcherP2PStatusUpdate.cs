using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PatcherP2PStatusUpdate
    {
        [JsonProperty("isAllowedByUser")]
        public bool IsAllowedByUser { get; set; }
    }
}
