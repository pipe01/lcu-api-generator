using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolGameQueuesQueueGameTypeConfig
    {
        [JsonProperty("advancedLearningQuests")]
        public bool AdvancedLearningQuests { get; set; }
        [JsonProperty("allowTrades")]
        public bool AllowTrades { get; set; }
        [JsonProperty("banMode")]
        public string BanMode { get; set; }
        [JsonProperty("banTimerDuration")]
        public int BanTimerDuration { get; set; }
        [JsonProperty("battleBoost")]
        public bool BattleBoost { get; set; }
        [JsonProperty("crossTeamChampionPool")]
        public bool CrossTeamChampionPool { get; set; }
        [JsonProperty("deathMatch")]
        public bool DeathMatch { get; set; }
        [JsonProperty("doNotRemove")]
        public bool DoNotRemove { get; set; }
        [JsonProperty("duplicatePick")]
        public bool DuplicatePick { get; set; }
        [JsonProperty("exclusivePick")]
        public bool ExclusivePick { get; set; }
        [JsonProperty("gameModeOverride")]
        public string GameModeOverride { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("learningQuests")]
        public bool LearningQuests { get; set; }
        [JsonProperty("mainPickTimerDuration")]
        public int MainPickTimerDuration { get; set; }
        [JsonProperty("maxAllowableBans")]
        public int MaxAllowableBans { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("numPlayersPerTeamOverride")]
        public int NumPlayersPerTeamOverride { get; set; }
        [JsonProperty("onboardCoopBeginner")]
        public bool OnboardCoopBeginner { get; set; }
        [JsonProperty("pickMode")]
        public string PickMode { get; set; }
        [JsonProperty("postPickTimerDuration")]
        public int PostPickTimerDuration { get; set; }
        [JsonProperty("reroll")]
        public bool Reroll { get; set; }
        [JsonProperty("teamChampionPool")]
        public bool TeamChampionPool { get; set; }
    }
}
