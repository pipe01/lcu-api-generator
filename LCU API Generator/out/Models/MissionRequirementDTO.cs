using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class MissionRequirementDTO
    {
        [JsonProperty("expression")]
        public string Expression { get; set; }
    }
}
