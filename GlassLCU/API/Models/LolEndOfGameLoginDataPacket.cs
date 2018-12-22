using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEndOfGameLoginDataPacket
    {
        [JsonProperty("allSummonerData")]
        public LolEndOfGameLoginSummonerData AllSummonerData { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
        [JsonProperty("simpleMessages")]
        public LolEndOfGameSimpleMessage[] SimpleMessages { get; set; }
    }
}
