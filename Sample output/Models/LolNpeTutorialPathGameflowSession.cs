using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathGameflowSession
    {
        [JsonProperty("phase")]
        public LolNpeTutorialPathGameflowPhase Phase { get; set; }
    }
}
