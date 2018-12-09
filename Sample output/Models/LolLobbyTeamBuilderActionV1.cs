using Newtonsoft.Json;

namespace LCU_API_Generator
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
