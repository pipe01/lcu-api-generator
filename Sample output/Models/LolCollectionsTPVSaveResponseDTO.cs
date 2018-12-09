using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsTPVSaveResponseDTO
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}
