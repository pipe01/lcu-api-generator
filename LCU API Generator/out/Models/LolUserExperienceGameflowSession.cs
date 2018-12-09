using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolUserExperienceGameflowSession
    {
        [JsonProperty("phase")]
        public LolUserExperienceGameflowPhase Phase { get; set; }
    }
}
