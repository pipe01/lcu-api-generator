using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPreEndOfGameGameflowSessionResource
    {
        [JsonProperty("phase")]
        public LolPreEndOfGameGameflowPhase Phase { get; set; }
    }
}
