//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
