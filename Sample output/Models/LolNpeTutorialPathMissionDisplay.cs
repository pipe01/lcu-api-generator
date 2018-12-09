using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathMissionDisplay
    {
        [JsonProperty("attributes")]
        public string[] Attributes { get; set; }
    }
}
