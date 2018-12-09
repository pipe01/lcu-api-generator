using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLoadoutsInventoryResponseDTO
    {
        [JsonProperty("data")]
        public LolLoadoutsInventoryDTO Data { get; set; }
    }
}
