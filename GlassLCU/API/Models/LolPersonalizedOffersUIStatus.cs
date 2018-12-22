using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPersonalizedOffersUIStatus
    {
        [JsonProperty("endTime")]
        public string EndTime { get; set; }
        [JsonProperty("hubEnabled")]
        public bool HubEnabled { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("startTime")]
        public string StartTime { get; set; }
    }
}
