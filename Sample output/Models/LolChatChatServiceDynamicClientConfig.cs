using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatChatServiceDynamicClientConfig
    {
        [JsonProperty("ChatDomain")]
        public LolChatChatDomainConfig ChatDomain { get; set; }
        [JsonProperty("LcuSocial")]
        public LolChatLcuSocialConfig LcuSocial { get; set; }
    }
}
