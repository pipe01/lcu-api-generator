using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PartiesVoiceDTO
    {
        [JsonProperty("jwt")]
        public string Jwt { get; set; }
    }
}
