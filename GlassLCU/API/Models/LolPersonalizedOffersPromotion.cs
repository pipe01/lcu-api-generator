using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPersonalizedOffersPromotion
    {
        [JsonProperty("endTime")]
        public string EndTime { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("startTime")]
        public string StartTime { get; set; }
    }
}
