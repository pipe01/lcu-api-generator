using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class MissionDisplay
    {
        [JsonProperty("attributes")]
        public string[] Attributes { get; set; }
    }
}
