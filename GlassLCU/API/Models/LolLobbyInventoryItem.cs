using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyInventoryItem
    {
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
    }
}
