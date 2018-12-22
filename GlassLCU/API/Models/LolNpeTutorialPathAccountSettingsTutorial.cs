using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
