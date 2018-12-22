using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
