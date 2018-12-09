using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RewardLogo
    {
        [JsonProperty("logo")]
        public int Logo { get; set; }
        [JsonProperty("memberOwnedCount")]
        public int MemberOwnedCount { get; set; }
    }
}
