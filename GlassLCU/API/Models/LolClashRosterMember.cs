using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashRosterMember
    {
        [JsonProperty("currentBuyin")]
        public int CurrentBuyin { get; set; }
        [JsonProperty("incomingOffers")]
        public LolClashTicketOffer[] IncomingOffers { get; set; }
        [JsonProperty("isSubForOtherTeam")]
        public bool IsSubForOtherTeam { get; set; }
        [JsonProperty("isSubbedOut")]
        public bool IsSubbedOut { get; set; }
        [JsonProperty("isSubstitute")]
        public bool IsSubstitute { get; set; }
        [JsonProperty("position")]
        public Position Position { get; set; }
        [JsonProperty("previousBuyin")]
        public int PreviousBuyin { get; set; }
        [JsonProperty("replacedSummonerId")]
        public long ReplacedSummonerId { get; set; }
        [JsonProperty("state")]
        public LolClashRosterMemberState State { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("tier")]
        public int Tier { get; set; }
    }
}