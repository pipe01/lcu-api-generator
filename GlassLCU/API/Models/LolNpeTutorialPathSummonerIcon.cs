using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeTutorialPathSummonerIcon
    {
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }
    }
}
