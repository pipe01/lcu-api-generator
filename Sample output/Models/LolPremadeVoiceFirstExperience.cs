//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPremadeVoiceFirstExperience
    {
        [JsonProperty("showFirstExperienceInGame")]
        public bool ShowFirstExperienceInGame { get; set; }
        [JsonProperty("showFirstExperienceInLCU")]
        public bool ShowFirstExperienceInLCU { get; set; }
    }
}
