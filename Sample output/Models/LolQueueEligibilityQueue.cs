using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolQueueEligibilityQueue
    {
        [JsonProperty("allowablePremadeSizes")]
        public int[] AllowablePremadeSizes { get; set; }
        [JsonProperty("areFreeChampionsAllowed")]
        public bool AreFreeChampionsAllowed { get; set; }
        [JsonProperty("championsRequiredToPlay")]
        public int ChampionsRequiredToPlay { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("isRanked")]
        public bool IsRanked { get; set; }
        [JsonProperty("maxLevel")]
        public int MaxLevel { get; set; }
        [JsonProperty("maximumParticipantListSize")]
        public int MaximumParticipantListSize { get; set; }
        [JsonProperty("minLevel")]
        public int MinLevel { get; set; }
        [JsonProperty("numPlayersPerTeam")]
        public int NumPlayersPerTeam { get; set; }
        [JsonProperty("queueAvailability")]
        public LolQueueEligibilityQueueAvailability QueueAvailability { get; set; }
        [JsonProperty("showPositionSelector")]
        public bool ShowPositionSelector { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
