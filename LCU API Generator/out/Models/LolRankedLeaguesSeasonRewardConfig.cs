using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRankedLeaguesSeasonRewardConfig
    {
        [JsonProperty("QualificationWarningEnabled")]
        public bool QualificationWarningEnabled { get; set; }
    }
}
