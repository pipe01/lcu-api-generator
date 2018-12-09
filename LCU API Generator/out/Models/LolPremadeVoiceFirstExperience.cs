using Newtonsoft.Json;

namespace LCU_API_Generator
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
