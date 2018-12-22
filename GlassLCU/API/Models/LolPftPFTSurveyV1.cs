using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPftPFTSurveyV1
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}