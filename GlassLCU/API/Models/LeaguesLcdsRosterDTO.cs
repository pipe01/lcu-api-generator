using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LeaguesLcdsRosterDTO
    {
        [JsonProperty("memberList")]
        public LeaguesLcdsTeamMemberInfoDTO[] MemberList { get; set; }
    }
}
