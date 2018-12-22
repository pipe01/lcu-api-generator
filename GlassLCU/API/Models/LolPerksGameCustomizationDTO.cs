using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPerksGameCustomizationDTO
    {
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("content")]
        public string Content { get; set; }
        [JsonProperty("isTeambuilder")]
        public bool IsTeambuilder { get; set; }
        [JsonProperty("queueType")]
        public long QueueType { get; set; }
    }
}