using Newtonsoft.Json;

namespace LCU_API_Generator
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
