using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolReplaysReplayContextData
    {
        [JsonProperty("componentType")]
        public string ComponentType { get; set; }
    }
}
