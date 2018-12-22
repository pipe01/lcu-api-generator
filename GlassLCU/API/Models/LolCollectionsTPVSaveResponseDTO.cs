using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCollectionsTPVSaveResponseDTO
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}
