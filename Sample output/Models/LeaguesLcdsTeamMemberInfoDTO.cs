//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LeaguesLcdsTeamMemberInfoDTO
    {
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
        [JsonProperty("playerName")]
        public string PlayerName { get; set; }
    }
}
