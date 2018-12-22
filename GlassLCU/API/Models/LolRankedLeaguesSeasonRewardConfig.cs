using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRankedLeaguesSeasonRewardConfig
    {
        [JsonProperty("QualificationWarningEnabled")]
        public bool QualificationWarningEnabled { get; set; }
    }
}
