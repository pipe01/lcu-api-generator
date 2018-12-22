using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEndOfGameGameloopPlayerInfoV1
    {
        [JsonProperty("rerollDataBag")]
        public LolEndOfGameRerollDataBagForClientV1 RerollDataBag { get; set; }
    }
}
