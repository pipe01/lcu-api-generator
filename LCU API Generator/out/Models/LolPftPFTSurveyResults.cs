using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPftPFTSurveyResults
    {
        [JsonProperty("actions")]
        public LolPftPFTEvent[] Actions { get; set; }
        [JsonProperty("questionResponses")]
        public LolPftPFTQuestionResponse[] QuestionResponses { get; set; }
    }
}
