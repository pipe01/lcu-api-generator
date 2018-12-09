using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashNoShowPingResponseData
    {
        [JsonProperty("dodgeTime")]
        public long DodgeTime { get; set; }
        [JsonProperty("gameflowState")]
        public LolClashGameflowPhase GameflowState { get; set; }
        [JsonProperty("isPlaymodeRestricted")]
        public bool IsPlaymodeRestricted { get; set; }
        [JsonProperty("loginTime")]
        public long LoginTime { get; set; }
        [JsonProperty("readyCheckInfo")]
        public LolClashReadyCheckInfo ReadyCheckInfo { get; set; }
    }
}
