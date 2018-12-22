using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPerksPlayerInventory
    {
        [JsonProperty("ownedPageCount")]
        public int OwnedPageCount { get; set; }
    }
}
