using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderLoginSession
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("connected")]
        public bool Connected { get; set; }
        [JsonProperty("state")]
        public LolLobbyTeamBuilderLoginSessionState State { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}