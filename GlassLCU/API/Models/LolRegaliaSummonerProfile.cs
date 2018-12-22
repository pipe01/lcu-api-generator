using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRegaliaSummonerProfile
    {
        [JsonProperty("regalia")]
        public string Regalia { get; set; }
    }
}
