using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashClashConfig
    {
        [JsonProperty("DarkModeEntitlement")]
        public string DarkModeEntitlement { get; set; }
        [JsonProperty("EnabledState")]
        public LolClashClashState EnabledState { get; set; }
        [JsonProperty("HonorLevelRequired")]
        public int HonorLevelRequired { get; set; }
        [JsonProperty("HonorRefreshRetrySeconds")]
        public int HonorRefreshRetrySeconds { get; set; }
        [JsonProperty("IconConfig")]
        public string IconConfig { get; set; }
        [JsonProperty("IsPlaymodeRestrictionEnabled")]
        public bool IsPlaymodeRestrictionEnabled { get; set; }
        [JsonProperty("MaxTimeBeforeLockinNotifySeconds")]
        public int MaxTimeBeforeLockinNotifySeconds { get; set; }
        [JsonProperty("RewardGrantRetryIntervalSeconds")]
        public int RewardGrantRetryIntervalSeconds { get; set; }
        [JsonProperty("UseIndividualEntitlement")]
        public bool UseIndividualEntitlement { get; set; }
        [JsonProperty("Visibility")]
        public LolClashClashVisibility Visibility { get; set; }
        [JsonProperty("VoiceEobQuitDelaySeconds")]
        public int VoiceEobQuitDelaySeconds { get; set; }
        [JsonProperty("VoiceNoDelayAutoStartSeconds")]
        public int VoiceNoDelayAutoStartSeconds { get; set; }
        [JsonProperty("VoiceRandomStartMaxSeconds")]
        public int VoiceRandomStartMaxSeconds { get; set; }
        [JsonProperty("VoiceRandomStartMinSeconds")]
        public int VoiceRandomStartMinSeconds { get; set; }
        [JsonProperty("VoiceRetryCountLimit")]
        public int VoiceRetryCountLimit { get; set; }
        [JsonProperty("VoiceRetryDelaySeconds")]
        public int VoiceRetryDelaySeconds { get; set; }
    }
}
