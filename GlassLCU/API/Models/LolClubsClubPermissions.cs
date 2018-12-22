using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClubsClubPermissions
    {
        [JsonProperty("ADMIN")]
        public string[] ADMIN { get; set; }
        [JsonProperty("INVITEE")]
        public string[] INVITEE { get; set; }
        [JsonProperty("MEMBER")]
        public string[] MEMBER { get; set; }
        [JsonProperty("OFFICER")]
        public string[] OFFICER { get; set; }
        [JsonProperty("OWNER")]
        public string[] OWNER { get; set; }
        [JsonProperty("UNKNOWN")]
        public string[] UNKNOWN { get; set; }
    }
}
