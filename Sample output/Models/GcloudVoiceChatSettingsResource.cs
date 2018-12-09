using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class GcloudVoiceChatSettingsResource
    {
        [JsonProperty("currentCaptureDeviceHandle")]
        public string CurrentCaptureDeviceHandle { get; set; }
        [JsonProperty("currentRenderDeviceHandle")]
        public string CurrentRenderDeviceHandle { get; set; }
        [JsonProperty("localMicMuted")]
        public bool LocalMicMuted { get; set; }
        [JsonProperty("loopbackEnabled")]
        public bool LoopbackEnabled { get; set; }
        [JsonProperty("micLevel")]
        public int MicLevel { get; set; }
        [JsonProperty("speakerLevel")]
        public int SpeakerLevel { get; set; }
        [JsonProperty("vadHangoverTime")]
        public int VadHangoverTime { get; set; }
        [JsonProperty("vadSensitivity")]
        public int VadSensitivity { get; set; }
    }
}
