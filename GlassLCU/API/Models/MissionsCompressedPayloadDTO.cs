using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class MissionsCompressedPayloadDTO
    {
        [JsonProperty("missionsCompressed")]
        public string MissionsCompressed { get; set; }
    }
}
