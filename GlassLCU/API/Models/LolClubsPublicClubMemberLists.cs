using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClubsPublicClubMemberLists
    {
        [JsonProperty("activeMembers")]
        public LolClubsPublicClubPlayer[] ActiveMembers { get; set; }
    }
}
