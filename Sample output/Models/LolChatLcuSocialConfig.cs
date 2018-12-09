using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatLcuSocialConfig
    {
        [JsonProperty("AggressiveScanning")]
        public bool AggressiveScanning { get; set; }
        [JsonProperty("ForceChatFilter")]
        public bool ForceChatFilter { get; set; }
        [JsonProperty("QueueJobGraceSeconds")]
        public long QueueJobGraceSeconds { get; set; }
        [JsonProperty("ReplaceRichMessages")]
        public bool ReplaceRichMessages { get; set; }
        [JsonProperty("SilenceChatWhileInGame")]
        public bool SilenceChatWhileInGame { get; set; }
    }
}
