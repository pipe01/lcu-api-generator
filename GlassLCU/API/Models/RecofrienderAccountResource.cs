using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
