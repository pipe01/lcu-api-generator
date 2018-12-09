using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LeaguesLcdsTeamIdDTO
    {
        [JsonProperty("fullId")]
        public string FullId { get; set; }
    }
}
