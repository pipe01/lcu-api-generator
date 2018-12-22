using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeTutorialPathMissionDisplay
    {
        [JsonProperty("attributes")]
        public string[] Attributes { get; set; }
    }
}
