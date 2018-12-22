using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LeaguesLcdsTeamIdDTO
    {
        [JsonProperty("fullId")]
        public string FullId { get; set; }
    }
}
