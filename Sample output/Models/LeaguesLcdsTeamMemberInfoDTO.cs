using Newtonsoft.Json;

namespace LCU_API_Generator
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
