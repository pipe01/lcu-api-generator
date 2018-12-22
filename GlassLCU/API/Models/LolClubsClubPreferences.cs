using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClubsClubPreferences
    {
        [JsonProperty("primaryClubKey")]
        public string PrimaryClubKey { get; set; }
        [JsonProperty("shareClubAffiliation")]
        public bool ShareClubAffiliation { get; set; }
    }
}
