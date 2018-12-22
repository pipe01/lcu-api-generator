using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPerksPerkBook
    {
        [JsonProperty("currentPageId")]
        public int CurrentPageId { get; set; }
        [JsonProperty("pages")]
        public LolPerksPerkPageResource[] Pages { get; set; }
    }
}
