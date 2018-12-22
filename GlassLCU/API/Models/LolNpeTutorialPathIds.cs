using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeTutorialPathIds
    {
        [JsonProperty("missionIds")]
        public string[] MissionIds { get; set; }
        [JsonProperty("seriesIds")]
        public string[] SeriesIds { get; set; }
    }
}
