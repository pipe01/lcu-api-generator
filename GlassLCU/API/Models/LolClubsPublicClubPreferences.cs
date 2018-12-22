using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClubsPublicClubPreferences
    {
        [JsonProperty("shareClubAffiliation")]
        public bool ShareClubAffiliation { get; set; }
    }
}
