using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPremadeVoiceAccountSettingsCategoryDataResource
    {
        [JsonProperty("autoJoin")]
        public bool AutoJoin { get; set; }
        [JsonProperty("inputMode")]
        public LolPremadeVoiceInputMode InputMode { get; set; }
        [JsonProperty("muteOnConnect")]
        public bool MuteOnConnect { get; set; }
        [JsonProperty("pushToTalkKey")]
        public string PushToTalkKey { get; set; }
        [JsonProperty("showFirstExperienceInGame")]
        public bool ShowFirstExperienceInGame { get; set; }
        [JsonProperty("showFirstExperienceInLCU")]
        public bool ShowFirstExperienceInLCU { get; set; }
    }
}
