using Newtonsoft.Json;

namespace GlassLCU.API.Models
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