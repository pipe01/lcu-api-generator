using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolInventoryWalletResponseDTO
    {
        [JsonProperty("data")]
        public LolInventoryWalletDTO Data { get; set; }
    }
}
