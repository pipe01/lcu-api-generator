using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderCeremonyV1
    {
        [JsonProperty("duration")]
        public long Duration { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
