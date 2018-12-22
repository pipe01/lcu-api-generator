using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class IdsDTO
    {
        [JsonProperty("missionIds")]
        public string[] MissionIds { get; set; }
        [JsonProperty("seriesIds")]
        public string[] SeriesIds { get; set; }
    }
}
