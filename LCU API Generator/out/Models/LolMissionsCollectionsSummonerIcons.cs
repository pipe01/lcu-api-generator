using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMissionsCollectionsSummonerIcons
    {
        [JsonProperty("icons")]
        public int[] Icons { get; set; }
    }
}
