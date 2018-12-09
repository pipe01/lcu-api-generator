using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class MissionsCompressedPayloadDTO
    {
        [JsonProperty("missionsCompressed")]
        public string MissionsCompressed { get; set; }
    }
}
