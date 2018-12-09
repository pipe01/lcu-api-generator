using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathAccountSettingsTutorial
    {
        [JsonProperty("hasSeenTutorialPath")]
        public bool HasSeenTutorialPath { get; set; }
        [JsonProperty("hasSkippedTutorialPath")]
        public bool HasSkippedTutorialPath { get; set; }
        [JsonProperty("shouldSeeNewPlayerExperience")]
        public bool ShouldSeeNewPlayerExperience { get; set; }
    }
}
