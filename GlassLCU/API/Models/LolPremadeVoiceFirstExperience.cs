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
