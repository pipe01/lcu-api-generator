//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderActionV1
    {
        [JsonProperty("actionId")]
        public int ActionId { get; set; }
        [JsonProperty("actorCellId")]
        public int ActorCellId { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("completed")]
        public bool Completed { get; set; }
        [JsonProperty("duration")]
        public long Duration { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
