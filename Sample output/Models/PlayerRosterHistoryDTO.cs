using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PlayerRosterHistoryDTO
    {
        [JsonProperty("rosters")]
        public RosterMemberDTO[] Rosters { get; set; }
    }
}
