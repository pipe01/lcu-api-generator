using Newtonsoft.Json;

namespace LCU_API_Generator
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
