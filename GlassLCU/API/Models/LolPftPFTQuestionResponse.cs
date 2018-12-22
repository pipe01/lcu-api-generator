using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPftPFTQuestionResponse
    {
        [JsonProperty("questionId")]
        public long QuestionId { get; set; }
        [JsonProperty("responseData")]
        public object ResponseData { get; set; }
    }
}
