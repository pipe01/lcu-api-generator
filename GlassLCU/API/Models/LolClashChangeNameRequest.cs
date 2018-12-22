using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashChangeNameRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
