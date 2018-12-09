using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatChatDomainConfig
    {
        [JsonProperty("ChampSelectDomainName")]
        public string ChampSelectDomainName { get; set; }
        [JsonProperty("ClubDomainName")]
        public string ClubDomainName { get; set; }
        [JsonProperty("CustomGameDomainName")]
        public string CustomGameDomainName { get; set; }
        [JsonProperty("CustomTeamDomainName")]
        public string CustomTeamDomainName { get; set; }
        [JsonProperty("P2PDomainName")]
        public string P2PDomainName { get; set; }
        [JsonProperty("PostGameDomainName")]
        public string PostGameDomainName { get; set; }
        [JsonProperty("PrivateDomainName")]
        public string PrivateDomainName { get; set; }
        [JsonProperty("PublicDomainName")]
        public string PublicDomainName { get; set; }
        [JsonProperty("RankedTeamDomainName")]
        public string RankedTeamDomainName { get; set; }
        [JsonProperty("TeamBuilderDomainName")]
        public string TeamBuilderDomainName { get; set; }
    }
}