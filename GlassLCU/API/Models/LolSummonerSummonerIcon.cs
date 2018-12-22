using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolSummonerSummonerIcon
    {
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }
    }
}
