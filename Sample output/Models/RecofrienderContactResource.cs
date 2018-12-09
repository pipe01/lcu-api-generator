using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RecofrienderContactResource
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("action")]
        public string Action { get; set; }
        [JsonProperty("displayState")]
        public string DisplayState { get; set; }
        [JsonProperty("friendState")]
        public RecofrienderFriendState FriendState { get; set; }
        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("recommendScore")]
        public long RecommendScore { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}