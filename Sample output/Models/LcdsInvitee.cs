using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LcdsInvitee
    {
        [JsonProperty("inviteeState")]
        public LcdsInviteeState InviteeState { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
    }
}
