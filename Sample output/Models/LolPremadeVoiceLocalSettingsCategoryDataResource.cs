using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPremadeVoiceLocalSettingsCategoryDataResource
    {
        [JsonProperty("currentCaptureDeviceHandle")]
        public string CurrentCaptureDeviceHandle { get; set; }
        [JsonProperty("inputVolume")]
        public int InputVolume { get; set; }
        [JsonProperty("vadSensitivity")]
        public int VadSensitivity { get; set; }
    }
}
