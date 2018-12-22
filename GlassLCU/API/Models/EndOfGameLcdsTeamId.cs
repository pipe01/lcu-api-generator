using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class EndOfGameLcdsTeamId
    {
        [JsonProperty("fullId")]
        public string FullId { get; set; }
    }
}
