using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderTeamBuilderBoostInfo
    {
        [JsonProperty("activatorCellId")]
        public long ActivatorCellId { get; set; }
        [JsonProperty("allowBattleBoost")]
        public bool AllowBattleBoost { get; set; }
        [JsonProperty("battleBoostActivated")]
        public bool BattleBoostActivated { get; set; }
        [JsonProperty("boostableSkinCount")]
        public int BoostableSkinCount { get; set; }
        [JsonProperty("cost")]
        public long Cost { get; set; }
        [JsonProperty("unlockedSkinIds")]
        public long[] UnlockedSkinIds { get; set; }
    }
}
