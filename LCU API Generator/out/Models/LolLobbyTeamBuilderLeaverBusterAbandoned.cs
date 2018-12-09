using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderLeaverBusterAbandoned
    {
        [JsonProperty("abandonerName")]
        public string AbandonerName { get; set; }
    }
}
