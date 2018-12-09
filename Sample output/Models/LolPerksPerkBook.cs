using Newtonsoft.Json;

namespace LCU_API_Generator
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
