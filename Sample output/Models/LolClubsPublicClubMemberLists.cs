using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsPublicClubMemberLists
    {
        [JsonProperty("activeMembers")]
        public LolClubsPublicClubPlayer[] ActiveMembers { get; set; }
    }
}
