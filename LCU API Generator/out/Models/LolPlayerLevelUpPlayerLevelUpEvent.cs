using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPlayerLevelUpPlayerLevelUpEvent
    {
        [JsonProperty("leveledUp")]
        public bool LeveledUp { get; set; }
        [JsonProperty("newQueues")]
        public int[] NewQueues { get; set; }
        [JsonProperty("newRuneSlotUnlocked")]
        public bool NewRuneSlotUnlocked { get; set; }
        [JsonProperty("newSpells")]
        public long[] NewSpells { get; set; }
        [JsonProperty("newSummonerLevel")]
        public int NewSummonerLevel { get; set; }
        [JsonProperty("nowHasAccessToLoot")]
        public bool NowHasAccessToLoot { get; set; }
        [JsonProperty("nowHasAccessToPublicChatRooms")]
        public bool NowHasAccessToPublicChatRooms { get; set; }
        [JsonProperty("rpEarned")]
        public int RpEarned { get; set; }
        [JsonProperty("switchedToStandardFreeToPlayChampRotation")]
        public bool SwitchedToStandardFreeToPlayChampRotation { get; set; }
    }
}
