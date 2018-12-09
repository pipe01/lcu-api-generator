using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LeaguesLcdsRosterDTO
    {
        [JsonProperty("memberList")]
        public LeaguesLcdsTeamMemberInfoDTO[] MemberList { get; set; }
    }
}
