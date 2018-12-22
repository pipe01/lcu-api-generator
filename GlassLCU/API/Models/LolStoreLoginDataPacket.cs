using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolStoreLoginDataPacket
    {
        [JsonProperty("allSummonerData")]
        public LolStoreAllSummonerData AllSummonerData { get; set; }
        [JsonProperty("simpleMessages")]
        public LolStoreSimpleDialogMessage[] SimpleMessages { get; set; }
    }
}
