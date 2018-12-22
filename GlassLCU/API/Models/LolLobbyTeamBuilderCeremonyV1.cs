using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
