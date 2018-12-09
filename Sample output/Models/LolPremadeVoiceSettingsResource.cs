using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPremadeVoiceSettingsResource
    {
        [JsonProperty("autoJoin")]
        public bool AutoJoin { get; set; }
        [JsonProperty("currentCaptureDeviceHandle")]
        public string CurrentCaptureDeviceHandle { get; set; }
        [JsonProperty("inputMode")]
        public LolPremadeVoiceInputMode InputMode { get; set; }
        [JsonProperty("localMicMuted")]
        public bool LocalMicMuted { get; set; }
        [JsonProperty("loopbackEnabled")]
        public bool LoopbackEnabled { get; set; }
        [JsonProperty("micLevel")]
        public int MicLevel { get; set; }
        [JsonProperty("muteOnConnect")]
        public bool MuteOnConnect { get; set; }
        [JsonProperty("pttActive")]
        public bool PttActive { get; set; }
        [JsonProperty("pttKey")]
        public string PttKey { get; set; }
        [JsonProperty("vadActive")]
        public bool VadActive { get; set; }
        [JsonProperty("vadHangoverTime")]
        public int VadHangoverTime { get; set; }
        [JsonProperty("vadSensitivity")]
        public int VadSensitivity { get; set; }
    }
}
