using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RecofrienderAccountResource
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("contacts")]
        public RecofrienderActionResource[] Contacts { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
    }
}
