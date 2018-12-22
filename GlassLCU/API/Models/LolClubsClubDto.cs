using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClubsClubDto
    {
        [JsonProperty("clubData")]
        public LolClubsClubDataDto ClubData { get; set; }
        [JsonProperty("membership")]
        public LolClubsClubMembershipDto Membership { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
        [JsonProperty("resourceUri")]
        public string ResourceUri { get; set; }
    }
}
