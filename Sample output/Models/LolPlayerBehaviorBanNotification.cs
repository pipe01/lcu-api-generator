using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPlayerBehaviorBanNotification
    {
        [JsonProperty("displayReformCard")]
        public bool DisplayReformCard { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("isPermaBan")]
        public bool IsPermaBan { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
        [JsonProperty("source")]
        public LolPlayerBehaviorNotificationSource Source { get; set; }
        [JsonProperty("timeUntilBanExpires")]
        public long TimeUntilBanExpires { get; set; }
    }
}
