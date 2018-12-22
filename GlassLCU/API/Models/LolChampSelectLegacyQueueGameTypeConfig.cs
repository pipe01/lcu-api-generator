using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
