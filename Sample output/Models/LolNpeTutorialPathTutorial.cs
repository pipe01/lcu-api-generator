using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathTutorial
    {
        [JsonProperty("backgroundUrl")]
        public string BackgroundUrl { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("isViewed")]
        public bool IsViewed { get; set; }
        [JsonProperty("queueId")]
        public string QueueId { get; set; }
        [JsonProperty("rewards")]
        public LolNpeTutorialPathTutorialReward[] Rewards { get; set; }
        [JsonProperty("status")]
        public LolNpeTutorialPathTutorialStatus Status { get; set; }
        [JsonProperty("stepNumber")]
        public int StepNumber { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("type")]
        public LolNpeTutorialPathTutorialType Type { get; set; }
        [JsonProperty("useChosenChampion")]
        public bool UseChosenChampion { get; set; }
        [JsonProperty("useQuickSearchMatchmaking")]
        public bool UseQuickSearchMatchmaking { get; set; }
    }
}
