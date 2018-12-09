using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampSelectLegacyQueueGameTypeConfig
    {
        [JsonProperty("allowTrades")]
        public bool AllowTrades { get; set; }
        [JsonProperty("battleBoost")]
        public bool BattleBoost { get; set; }
        [JsonProperty("maxAllowableBans")]
        public int MaxAllowableBans { get; set; }
    }
}
