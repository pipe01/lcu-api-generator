using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCollectionsCollectionLoginDataPacket
    {
        [JsonProperty("allSummonerData")]
        public LolCollectionsSummonerData AllSummonerData { get; set; }
    }
}
