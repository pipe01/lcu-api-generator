using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class MissionRequirementDTO
    {
        [JsonProperty("expression")]
        public string Expression { get; set; }
    }
}
