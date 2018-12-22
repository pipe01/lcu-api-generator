using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PlayerRosterHistoryDTO
    {
        [JsonProperty("rosters")]
        public RosterMemberDTO[] Rosters { get; set; }
    }
}
