using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLoginLoginSession
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("connected")]
        public bool Connected { get; set; }
        [JsonProperty("error")]
        public LolLoginLoginError Error { get; set; }
        [JsonProperty("gasToken")]
        public object GasToken { get; set; }
        [JsonProperty("idToken")]
        public string IdToken { get; set; }
        [JsonProperty("isNewPlayer")]
        public bool IsNewPlayer { get; set; }
        [JsonProperty("puuid")]
        public string Puuid { get; set; }
        [JsonProperty("queueStatus")]
        public LolLoginLoginQueue QueueStatus { get; set; }
        [JsonProperty("state")]
        public LolLoginLoginSessionStates State { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("userAuthToken")]
        public string UserAuthToken { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
    }
}
