//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class VoiceChatDeviceResource
    {
        [JsonProperty("handle")]
        public string Handle { get; set; }
        [JsonProperty("is_current_device")]
        public bool Is_current_device { get; set; }
        [JsonProperty("is_default")]
        public bool Is_default { get; set; }
        [JsonProperty("is_effective_device")]
        public bool Is_effective_device { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
