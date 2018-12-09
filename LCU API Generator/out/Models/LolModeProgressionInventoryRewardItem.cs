using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolModeProgressionInventoryRewardItem
    {
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
    }
}
