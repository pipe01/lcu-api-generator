using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolInventorySimpleInventoryResponseDTO
    {
        [JsonProperty("data")]
        public LolInventorySimpleInventoryDTO Data { get; set; }
    }
}
