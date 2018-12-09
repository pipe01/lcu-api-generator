using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathAccountSettingsHowToWinStats
    {
        [JsonProperty("creepScore")]
        public LolNpeTutorialPathHowToWinCreepScoreDto CreepScore { get; set; }
        [JsonProperty("objectives")]
        public LolNpeTutorialPathHowToWinObjectivesDto Objectives { get; set; }
        [JsonProperty("ready")]
        public bool Ready { get; set; }
        [JsonProperty("takedowns")]
        public LolNpeTutorialPathHowToWinTakedownsDto Takedowns { get; set; }
    }
}