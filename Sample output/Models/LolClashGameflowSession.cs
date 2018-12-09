using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashGameflowSession
    {
        [JsonProperty("phase")]
        public LolClashGameflowPhase Phase { get; set; }
    }
}
