using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPlayerLevelUpEndOfGameStats
    {
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("gameMutators")]
        public string[] GameMutators { get; set; }
        [JsonProperty("gameType")]
        public string GameType { get; set; }
        [JsonProperty("leveledUp")]
        public bool LeveledUp { get; set; }
        [JsonProperty("newSpells")]
        public int[] NewSpells { get; set; }
        [JsonProperty("previousLevel")]
        public int PreviousLevel { get; set; }
        [JsonProperty("queueType")]
        public string QueueType { get; set; }
        [JsonProperty("rpEarned")]
        public int RpEarned { get; set; }
    }
}
