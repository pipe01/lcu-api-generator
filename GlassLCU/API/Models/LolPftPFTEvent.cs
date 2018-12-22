using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPftPFTEvent
    {
        [JsonProperty("action")]
        public string Action { get; set; }
        [JsonProperty("data")]
        public object[] Data { get; set; }
        [JsonProperty("playerSurveyId")]
        public long PlayerSurveyId { get; set; }
    }
}
