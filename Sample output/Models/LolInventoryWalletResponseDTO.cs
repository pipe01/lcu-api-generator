using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolInventoryWalletResponseDTO
    {
        [JsonProperty("data")]
        public LolInventoryWalletDTO Data { get; set; }
    }
}
