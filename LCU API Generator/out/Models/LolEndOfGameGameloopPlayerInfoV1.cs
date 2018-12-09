using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolEndOfGameGameloopPlayerInfoV1
    {
        [JsonProperty("rerollDataBag")]
        public LolEndOfGameRerollDataBagForClientV1 RerollDataBag { get; set; }
    }
}
