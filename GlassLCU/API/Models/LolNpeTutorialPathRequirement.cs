using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeTutorialPathRequirement
    {
        [JsonProperty("expression")]
        public string Expression { get; set; }
    }
}
