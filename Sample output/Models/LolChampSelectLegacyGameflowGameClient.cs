using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampSelectLegacyGameflowGameClient
    {
        [JsonProperty("running")]
        public bool Running { get; set; }
        [JsonProperty("visible")]
        public bool Visible { get; set; }
    }
}
