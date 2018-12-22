using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class MissionProgressDTO
    {
        [JsonProperty("currentProgress")]
        public int CurrentProgress { get; set; }
        [JsonProperty("lastViewedProgress")]
        public int LastViewedProgress { get; set; }
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
    }
}