using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashSimpleStateFlag
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("status")]
        public LolClashSimpleStateStatus Status { get; set; }
    }
}
