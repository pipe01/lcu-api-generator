using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClubsClubName
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
