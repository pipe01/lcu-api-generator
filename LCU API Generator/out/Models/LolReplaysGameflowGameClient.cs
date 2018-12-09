using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolReplaysGameflowGameClient
    {
        [JsonProperty("running")]
        public bool Running { get; set; }
    }
}
