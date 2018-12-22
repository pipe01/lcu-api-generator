using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLoadoutsInventoryResponseDTO
    {
        [JsonProperty("data")]
        public LolLoadoutsInventoryDTO Data { get; set; }
    }
}
