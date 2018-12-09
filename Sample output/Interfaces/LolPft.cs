using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolPft
    {
        public static Task<object> PostLolPftV2Events([Parameter("pftEvent", "body")] LolPftPFTEvent pftEvent)
            => Sender.Request<object>("post", $"/lol-pft/v2/events", pftEvent);
        public static Task<LolPftPFTSurvey> GetLolPftV2Survey()
            => Sender.Request<LolPftPFTSurvey>("get", $"/lol-pft/v2/survey");
        public static Task PostLolPftV2Survey([Parameter("survey", "body")] LolPftPFTSurvey survey)
            => Sender.Request("post", $"/lol-pft/v2/survey", survey);
    }
}
