using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
