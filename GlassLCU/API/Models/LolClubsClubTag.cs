using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClubsClubTag
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }
    }
}
