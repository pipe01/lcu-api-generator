using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
