using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyInventoryItem
    {
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
    }
}
