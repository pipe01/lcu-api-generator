using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LeaguesLcdsTeamDTO
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("roster")]
        public LeaguesLcdsRosterDTO Roster { get; set; }
        [JsonProperty("teamId")]
        public LeaguesLcdsTeamIdDTO TeamId { get; set; }
    }
}
