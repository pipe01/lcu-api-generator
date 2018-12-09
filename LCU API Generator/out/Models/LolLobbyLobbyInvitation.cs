using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyLobbyInvitation
    {
        [JsonProperty("eligibility")]
        public LolLobbyEligibility Eligibility { get; set; }
        [JsonProperty("errorType")]
        public string ErrorType { get; set; }
        [JsonProperty("fromSummonerId")]
        public long FromSummonerId { get; set; }
        [JsonProperty("fromSummonerName")]
        public string FromSummonerName { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("invitationMetaData")]
        public object InvitationMetaData { get; set; }
        [JsonProperty("state")]
        public LolLobbyLobbyInvitationState State { get; set; }
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
        [JsonProperty("toSummonerId")]
        public long ToSummonerId { get; set; }
        [JsonProperty("toSummonerName")]
        public string ToSummonerName { get; set; }
    }
}
