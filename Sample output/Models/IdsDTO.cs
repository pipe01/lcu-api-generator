using Newtonsoft.Json;

namespace LCU_API_Generator
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
