using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClubsPublicUserResource
    {
        [JsonProperty("availability")]
        public string Availability { get; set; }
        [JsonProperty("icon")]
        public int Icon { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("lastSeenOnlineTimestamp")]
        public string LastSeenOnlineTimestamp { get; set; }
        [JsonProperty("lol")]
        public object Lol { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
