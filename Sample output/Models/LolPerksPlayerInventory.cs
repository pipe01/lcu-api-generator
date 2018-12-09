using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPerksPlayerInventory
    {
        [JsonProperty("ownedPageCount")]
        public int OwnedPageCount { get; set; }
    }
}
