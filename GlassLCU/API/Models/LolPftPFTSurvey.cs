using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPftPFTSurvey
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }
        [JsonProperty("data")]
        public object Data { get; set; }
        [JsonProperty("display")]
        public string Display { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
