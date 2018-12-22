using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolModeProgressionInventoryRewardItem
    {
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
    }
}
