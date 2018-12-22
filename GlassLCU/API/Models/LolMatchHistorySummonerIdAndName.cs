using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMatchHistorySummonerIdAndName
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }
}
