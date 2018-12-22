using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolInventoryInventoryResponseDTO
    {
        [JsonProperty("data")]
        public LolInventoryInventoryDTO Data { get; set; }
    }
}
