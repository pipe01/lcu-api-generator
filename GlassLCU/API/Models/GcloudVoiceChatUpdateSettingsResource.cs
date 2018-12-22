using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class GcloudVoiceChatUpdateSettingsResource
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
