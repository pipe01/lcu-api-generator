using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolReplaysReplaysConfiguration
    {
        [JsonProperty("gameVersion")]
        public string GameVersion { get; set; }
        [JsonProperty("isInTournament")]
        public bool IsInTournament { get; set; }
        [JsonProperty("isLoggedIn")]
        public bool IsLoggedIn { get; set; }
        [JsonProperty("isPatching")]
        public bool IsPatching { get; set; }
        [JsonProperty("isPlayingGame")]
        public bool IsPlayingGame { get; set; }
        [JsonProperty("isPlayingReplay")]
        public bool IsPlayingReplay { get; set; }
        [JsonProperty("isReplaysEnabled")]
        public bool IsReplaysEnabled { get; set; }
        [JsonProperty("isReplaysForEndOfGameEnabled")]
        public bool IsReplaysForEndOfGameEnabled { get; set; }
        [JsonProperty("isReplaysForMatchHistoryEnabled")]
        public bool IsReplaysForMatchHistoryEnabled { get; set; }
        [JsonProperty("minServerVersion")]
        public string MinServerVersion { get; set; }
        [JsonProperty("minutesUntilReplayConsideredLost")]
        public float MinutesUntilReplayConsideredLost { get; set; }
    }
}
