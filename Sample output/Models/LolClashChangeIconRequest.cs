using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashChangeIconRequest
    {
        [JsonProperty("iconColorId")]
        public int IconColorId { get; set; }
        [JsonProperty("iconId")]
        public int IconId { get; set; }
    }
}
