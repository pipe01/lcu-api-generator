using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RecofrienderContactStateResource
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("action")]
        public string Action { get; set; }
        [JsonProperty("displayState")]
        public string DisplayState { get; set; }
    }
}
