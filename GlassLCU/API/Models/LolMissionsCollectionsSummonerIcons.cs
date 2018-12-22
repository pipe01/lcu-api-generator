using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMissionsCollectionsSummonerIcons
    {
        [JsonProperty("icons")]
        public int[] Icons { get; set; }
    }
}
