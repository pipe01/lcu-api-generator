using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLootGameflowSession
    {
        [JsonProperty("phase")]
        public LolLootGameflowPhase Phase { get; set; }
    }
}
