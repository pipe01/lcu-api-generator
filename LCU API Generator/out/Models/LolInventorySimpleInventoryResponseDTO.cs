using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolInventorySimpleInventoryResponseDTO
    {
        [JsonProperty("data")]
        public LolInventorySimpleInventoryDTO Data { get; set; }
    }
}
