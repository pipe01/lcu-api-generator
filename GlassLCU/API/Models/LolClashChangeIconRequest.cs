using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
