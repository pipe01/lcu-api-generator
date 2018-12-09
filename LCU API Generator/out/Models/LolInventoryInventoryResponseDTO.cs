using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolInventoryInventoryResponseDTO
    {
        [JsonProperty("data")]
        public LolInventoryInventoryDTO Data { get; set; }
    }
}
