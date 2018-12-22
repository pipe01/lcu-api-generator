using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeTutorialPathTutorialMetadata
    {
        [JsonProperty("displayRewards")]
        public object DisplayRewards { get; set; }
        [JsonProperty("queueId")]
        public string QueueId { get; set; }
        [JsonProperty("stepNumber")]
        public int StepNumber { get; set; }
        [JsonProperty("useChosenChampion")]
        public bool UseChosenChampion { get; set; }
        [JsonProperty("useQuickSearchMatchmaking")]
        public bool UseQuickSearchMatchmaking { get; set; }
    }
}
