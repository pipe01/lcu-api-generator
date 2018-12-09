using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathParticipantIdentityPlayer
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
