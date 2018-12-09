using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampSelectLegacyGameflowGameDodge
    {
        [JsonProperty("dodgeIds")]
        public long[] DodgeIds { get; set; }
        [JsonProperty("state")]
        public LolChampSelectLegacyGameflowGameDodgeState State { get; set; }
    }
}
