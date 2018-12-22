using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolSummonerSummonerRequestedName
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
