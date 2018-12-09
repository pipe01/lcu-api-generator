using Newtonsoft.Json;

namespace LCU_API_Generator
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
