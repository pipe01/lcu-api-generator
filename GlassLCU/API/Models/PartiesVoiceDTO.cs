using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PartiesVoiceDTO
    {
        [JsonProperty("jwt")]
        public string Jwt { get; set; }
    }
}
